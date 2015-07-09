using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder.Builders.Description {
    public partial class DescriptionSelectorControl : UserControl {
        private DescriptionControl lastDescriptionControl;
        private CardDescriptionContainer container;
        private CardUpdater updater;
        public DescriptionSelectorControl(List<UserControl> descriptionControls, CardUpdater updater, CardDescriptionContainer container) {
            this.updater = updater;
            this.container = container;
            InitializeComponent();
            descriptionComboBox.DisplayMember = "name";
            descriptionControls.ForEach(c => {
                descriptionComboBox.Items.Add(c);
                DescriptionControl typeDescription = (DescriptionControl)c;
                if (typeDescription.typeDescription.Equals(container.type)) {
                    typeDescription.cardDescription = container.description;
                    descriptionComboBox.SelectedItem = c;
                }
            });
            if (descriptionComboBox.SelectedIndex == -1) {
                descriptionComboBox.SelectedIndex = 0;
            }
        }

        public void updateComboBox() {
            if (descriptionComboBox.SelectedItem != null) {
                DescriptionControl typeDescription = (DescriptionControl)descriptionComboBox.SelectedItem;
                descriptionPanel.Controls.Clear();
                descriptionPanel.Controls.Add((UserControl)typeDescription);
                lastDescriptionControl = typeDescription;
                container.description = typeDescription.cardDescription;
                updater.updateCard();
            }
        }

        private void descriptionComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            updateComboBox();
        }
    }
}

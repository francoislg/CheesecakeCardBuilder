using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder.Builders.Gear {
    using CheesecakeCardBuilder.Config;
using CheesecakeCardBuilder.Builders.Description;
    using CheesecakeCardBuilder.Gear;
    public partial class GearCardControl : UserControl, CardControl {
        private ProjectConfig config;
        private GearCard gearCard = new GearCard();
        private CardUpdater updater;
        public GearCardControl(ProjectConfig config, CardUpdater updater) {
            this.config = config;
            this.updater = updater;
            InitializeComponent();
            typeComboBox.DataSource = Enum.GetValues(typeof(GearType));
        }

        public void loadCard(Card card) {
            GearCard newCard = card as GearCard;
            resTextBox.DataBindings.Add("Text", newCard, "res", false, DataSourceUpdateMode.OnPropertyChanged);
            atkTextBox.DataBindings.Add("Text", newCard, "atk", false, DataSourceUpdateMode.OnPropertyChanged);
            defTextBox.DataBindings.Add("Text", newCard, "def", false, DataSourceUpdateMode.OnPropertyChanged);
            rareCheckbox.DataBindings.Add("Checked", newCard, "rare", false, DataSourceUpdateMode.OnPropertyChanged);
            for (int i = 0; i < newCard.descriptions.Count(); i++) {
                CardDescriptionContainer container = new CardDescriptionContainer(newCard, i);
                descriptionsPanel.Controls.Add(new DescriptionSelectorControl(getNewDescriptionControls(), updater, container));
            }
            this.gearCard = newCard;
        }

        private List<UserControl> getNewDescriptionControls() {
            List<UserControl> descriptionControls = new List<UserControl>();
            descriptionControls.Add(new DefaultDescriptionControl(config, updater));
            return descriptionControls;
        }

        private void resTextBox_TextChanged(object sender, EventArgs e) {
            updater.updateCard();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            this.gearCard.gearType = (GearType)typeComboBox.SelectedItem;
            updater.updateCard();
        }
    }
}

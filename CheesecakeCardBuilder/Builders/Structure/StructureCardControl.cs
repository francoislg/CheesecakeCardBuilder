using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder.Builders.Structure {
    using CheesecakeCardBuilder.Structure;
    using CheesecakeCardBuilder.Config;
    public partial class StructureCardControl : UserControl, CardControl {
        private ProjectConfig config;
        private StructureCard structureCard = new StructureCard();
        private CardUpdater updater;
        private StructureDescriptionControl descControl;

        public StructureCardControl(ProjectConfig config, CardUpdater updater) {
            this.config = config;
            this.updater = updater;
            InitializeComponent();
            descControl = new StructureDescriptionControl(config, updater);
            descriptionPanel.Controls.Clear();
            descriptionPanel.Controls.Add((UserControl)descControl);
            typeComboBox.DataSource = Enum.GetValues(typeof(StructureType));
        }

        public void loadCard(Card card) {
            StructureCard newCard = card as StructureCard;
            resTextbox.DataBindings.Add("Text", newCard, "res", false, DataSourceUpdateMode.OnPropertyChanged);
            prodTextbox.DataBindings.Add("Text", newCard, "prod", false, DataSourceUpdateMode.OnPropertyChanged);
            storTextbox.DataBindings.Add("Text", newCard, "storage", false, DataSourceUpdateMode.OnPropertyChanged);
            storSpeedTextbox.DataBindings.Add("Text", newCard, "storSpeed", false, DataSourceUpdateMode.OnPropertyChanged);
            descControl.description = newCard.descriptions[0];
            newCard.descriptions[0] = descControl.description;
            this.structureCard = newCard;
        }

        private void typeCombobox_SelectedIndexChanged(object sender, EventArgs e) {
            structureCard.structureType = (StructureType)typeComboBox.SelectedItem;
            updater.updateCard();
        }

        private void resTextbox_TextChanged(object sender, EventArgs e) {
            updater.updateCard();
        }
    }
}

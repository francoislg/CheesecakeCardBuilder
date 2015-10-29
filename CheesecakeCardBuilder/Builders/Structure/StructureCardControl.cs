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
    using CheesecakeCardBuilder.Builders.Description;
    public partial class StructureCardControl : UserControl, CardControl {
        private ProjectConfig config;
        private StructureCard structureCard = new StructureCard();
        private CardUpdater updater;

        public StructureCardControl(ProjectConfig config, CardUpdater updater) {
            this.config = config;
            this.updater = updater;
            InitializeComponent();
            typeComboBox.DataSource = Enum.GetValues(typeof(StructureType));
        }

        public void loadCard(Card card) {
            StructureCard newCard = card as StructureCard;
            resTextbox.DataBindings.Add("Text", newCard, "res", false, DataSourceUpdateMode.OnPropertyChanged);
            prodTextbox.DataBindings.Add("Text", newCard, "prod", false, DataSourceUpdateMode.OnPropertyChanged);
            storTextbox.DataBindings.Add("Text", newCard, "storage", false, DataSourceUpdateMode.OnPropertyChanged);
            storSpeedTextbox.DataBindings.Add("Text", newCard, "storSpeed", false, DataSourceUpdateMode.OnPropertyChanged);
            rareCheckbox.DataBindings.Add("Checked", newCard, "rare", false, DataSourceUpdateMode.OnPropertyChanged);
            for (int i = 0; i < newCard.descriptions.Count(); i++) {
                CardDescriptionContainer container = new CardDescriptionContainer(newCard, i);
                descriptionsPanel.Controls.Add(new DescriptionSelectorControl(getNewDescriptionControls(), updater, container));
            }
            this.structureCard = newCard;
        }

        private List<UserControl> getNewDescriptionControls() {
            List<UserControl> descriptionControls = new List<UserControl>();
            descriptionControls.Add(new OpenDescriptionControl(config, updater));
            return descriptionControls;
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

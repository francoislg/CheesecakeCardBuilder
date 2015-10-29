using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheesecakeCardBuilder.Config;

namespace CheesecakeCardBuilder.Builders.Unit {
    using CheesecakeCardBuilder.Builders.Description;
    using CheesecakeCardBuilder.Unit;
    public partial class UnitCardControl : UserControl, CardControl {
        private ProjectConfig config;
        private UnitCard unitCard = new UnitCard();
        private CardUpdater updater;

        public UnitCardControl(ProjectConfig config, CardUpdater updater) {
            this.config = config;
            this.updater = updater;
            InitializeComponent();
            typeComboBox.DataSource = Enum.GetValues(typeof(UnitType));
        }

        public void loadCard(Card card) {
            UnitCard newCard = card as UnitCard;
            hpTextbox.DataBindings.Add("Text", newCard, "hp", false, DataSourceUpdateMode.OnPropertyChanged);
            resTextbox.DataBindings.Add("Text", newCard, "res", false, DataSourceUpdateMode.OnPropertyChanged);
            accTextBox.DataBindings.Add("Text", newCard, "acc", false, DataSourceUpdateMode.OnPropertyChanged);
            atkTextBox.DataBindings.Add("Text", newCard, "atk", false, DataSourceUpdateMode.OnPropertyChanged);
            defTextBox.DataBindings.Add("Text", newCard, "def", false, DataSourceUpdateMode.OnPropertyChanged);
            spdTextbox.DataBindings.Add("Text", newCard, "spd", false, DataSourceUpdateMode.OnPropertyChanged);
            typeComboBox.SelectedItem = newCard.unitType;
            for (int i = 0; i < newCard.descriptions.Count(); i++) {
                CardDescriptionContainer container = new CardDescriptionContainer(newCard, i);
                descriptionsPanel.Controls.Add(new DescriptionSelectorControl(getNewDescriptionControls(), updater, container));
            }
            this.unitCard = newCard;
        }

        private List<UserControl> getNewDescriptionControls() {
            List<UserControl> descriptionControls = new List<UserControl>();
            descriptionControls.Add(new EmptyDescriptionControl(config, updater));
            descriptionControls.Add(new DefaultDescriptionControl(config, updater));
            descriptionControls.Add(new KeywordDescriptionControl(config, updater));
            return descriptionControls;
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            unitCard.unitType = (UnitType)typeComboBox.SelectedItem;
            updater.updateCard();
        }

        private void hpTextbox_TextChanged(object sender, EventArgs e) {
            updater.updateCard();
        }
    }
}

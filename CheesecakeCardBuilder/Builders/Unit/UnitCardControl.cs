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

namespace CheesecakeCardBuilder.Builder.Unit {
    using CheesecakeCardBuilder.Unit;
    public partial class UnitCardControl : UserControl, CardControl {
        private ProjectConfig config;
        private UnitCard unitCard;
        private CardUpdater updater;
        private ComboBox[] descriptionsComboBox;
        private Panel[] descriptionsPanel;
        private UnitDescriptionControl[] lastUnitDescription = new UnitDescriptionControl[2];

        public UnitCardControl(ProjectConfig config, UnitCard card, CardUpdater updater) {
            this.config = config;
            this.unitCard = card;
            this.updater = updater;
            InitializeComponent();
            descriptionsComboBox = new ComboBox[] { descriptionComboBox, descriptionComboBox2 };
            descriptionsPanel = new Panel[] { descriptionPanel, descriptionPanel2 };
            typeComboBox.DataSource = Enum.GetValues(typeof(UnitType));
            addDescriptions();
        }

        private void addDescriptions() {
            for (int i = 0; i < unitCard.descriptions.Count(); i++) {
                descriptionsComboBox[i].DisplayMember = "name";
                descriptionsComboBox[i].Tag = i;
                descriptionsComboBox[i].Items.Add(new EmptyUnitDescriptionControl(config, updater));
                descriptionsComboBox[i].Items.Add(new DefaultUnitDescriptionControl(config, updater));
                descriptionsComboBox[i].Items.Add(new KeywordUnitDescriptionControl(config, updater));
                descriptionsComboBox[i].SelectedIndex = 0;
            }
        }

        public void loadCard(Card card) {
            UnitCard newCard = card as UnitCard;
            hpTextbox.DataBindings.Add("Text", newCard, "hp");
            resTextbox.DataBindings.Add("Text", newCard, "res");
            accTextBox.DataBindings.Add("Text", newCard, "acc");
            atkTextBox.DataBindings.Add("Text", newCard, "atk");
            defTextBox.DataBindings.Add("Text", newCard, "def");
            spdTextbox.DataBindings.Add("Text", newCard, "spd");
            typeComboBox.SelectedItem = newCard.unitType;
            for (int i = 0; i < newCard.descriptions.Count(); i++) {
                descriptionsComboBox[i].Text = newCard.descriptions[i].type.ToString();
                updateComboBox(i);
                lastUnitDescription[i].description = newCard.descriptions[i];
                newCard.descriptions[i] = lastUnitDescription[i].description;
            }
            this.unitCard = newCard;
        }

        private void updateComboBox(int i) {
            if (lastUnitDescription[i] != null) {
                unitCard.descriptions[i] = new UnitDescription();
                lastUnitDescription[i].clear();
            }
            ComboBox descComboBox = descriptionsComboBox[i];
            if (descComboBox.SelectedItem != null) {
                UnitDescriptionControl typeDescription = (UnitDescriptionControl)descComboBox.SelectedItem;
                descriptionsPanel[i].Controls.Clear();
                descriptionsPanel[i].Controls.Add((UserControl)typeDescription);
                unitCard.descriptions[i] = typeDescription.description;
                lastUnitDescription[i] = typeDescription;
                updater.updateCard();
            }
        }

        private void descriptionComboBox_SelectedValueChanged(object sender, EventArgs e) {
            ComboBox descComboBox = (ComboBox)sender;
            int i = (int)descComboBox.Tag;
            updateComboBox(i);
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

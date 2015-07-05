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

namespace CheesecakeCardBuilder.Unit {
    public partial class UnitCardControl : UserControl, CardControl {
        private ProjectConfig config;
        private UnitCard unitCard;
        private CardUpdater updater;
        private ComboBox[] descriptionsComboBox;
        private Panel[] descriptionsPanel;
        private UnitDescriptionControl[] lastUnitDescription = new UnitDescriptionControl[2];

        public UnitCardControl(ProjectConfig config, Card card, CardUpdater updater) {
            this.config = config;
            this.unitCard = (UnitCard)card;
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
            hpTextbox.Text = newCard.hp;
            resTextbox.Text = newCard.res;
            accTextBox.Text = newCard.acc;
            atkTextBox.Text = newCard.atk;
            defTextBox.Text = newCard.def;
            spdTextbox.Text = newCard.spd;
            typeComboBox.SelectedItem = newCard.unitType;
            for (int i = 0; i < newCard.descriptions.Count(); i++) {
                descriptionsComboBox[i].Text = newCard.descriptions[i].type.ToString();
                updateComboBox(i);
                lastUnitDescription[i].description = newCard.descriptions[i];
                newCard.descriptions[i] = lastUnitDescription[i].description;
            }
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
                updater.updateCardDescription();
            }
        }

        private void descriptionComboBox_SelectedValueChanged(object sender, EventArgs e) {
            ComboBox descComboBox = (ComboBox)sender;
            int i = (int)descComboBox.Tag;
            updateComboBox(i);
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            unitCard.unitType = (UnitType)typeComboBox.SelectedItem;
            updater.updateCardDescription();
        }

        public void updateCard(Card cardToUpdate) {
            UnitCard card = cardToUpdate as UnitCard;
            card.atk = atkTextBox.Text;
            card.def = defTextBox.Text;
            card.spd = spdTextbox.Text;
            card.acc = accTextBox.Text;
            card.hp = hpTextbox.Text;
            card.res = resTextbox.Text;
        }
    }
}

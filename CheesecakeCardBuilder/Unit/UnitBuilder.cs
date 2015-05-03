using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder {
    using Config;
    using Unit;
    using Renderer;

    public partial class UnitBuilder : Form, CardUpdater {
        private class TypeDescriptions {
            public UserControl userControl {
                get {
                    return (UserControl)unitDescription;
                }
            }
            public String text {
                get {
                    return unitDescription.name;
                }
            }
            public UnitDescription unitDescription { get; set;}
        }

        private UnitCard card;
        private UnitCardRenderer unitCardRenderer;
        private ProjectConfig config;
        private UnitDescription lastUnitDescription;
        private UnitDescription lastUnitDescription2;

        public UnitBuilder(ProjectConfig config) {
            this.config = config;
            this.card = new UnitCard();
            this.unitCardRenderer = new UnitCardRenderer(card, config);
            InitializeComponent();
            descriptionComboBox.DisplayMember = "text";
            descriptionComboBox2.DisplayMember = "text";
            addDescriptions();
        }

        private void addDescriptions() {
            descriptionComboBox.Items.Add(new TypeDescriptions() { unitDescription = new DefaultUnitDescription(this) });
            descriptionComboBox2.Items.Add(new TypeDescriptions() { unitDescription = new DefaultUnitDescription(this) });
            descriptionComboBox.Items.Add(new TypeDescriptions() { unitDescription = new KeywordUnitDescription(this) });
            descriptionComboBox2.Items.Add(new TypeDescriptions() { unitDescription = new KeywordUnitDescription(this) });
        }

        public void updateCardDescription() {
            updateCard();
        }

        private void event_UpdatePicture(object sender, EventArgs e) {
            card.atk = atkTextBox.Text;
            card.def = defTextBox.Text;
            card.spd = spdTextbox.Text;
            card.acc = accTextBox.Text;
            card.hp = hpTextbox.Text;
            card.res = resTextbox.Text;
            card.name = nameTextBox.Text;
            updateCard();
        }

        private void updateCard() {
            previewPicture.Image = unitCardRenderer.generate();
        }

        private void descriptionComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (lastUnitDescription != null) {
                card.descriptions.Remove(lastUnitDescription);
            }
            TypeDescriptions typeDescription = (TypeDescriptions)descriptionComboBox.SelectedItem;
            descriptionPanel.Controls.Clear();
            descriptionPanel.Controls.Add(typeDescription.userControl);
            card.descriptions.Add(typeDescription.unitDescription);
            lastUnitDescription = typeDescription.unitDescription;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (lastUnitDescription2 != null) {
                card.descriptions.Remove(lastUnitDescription2);
            }
            TypeDescriptions typeDescription = (TypeDescriptions)descriptionComboBox2.SelectedItem;
            descriptionPanel2.Controls.Clear();
            descriptionPanel2.Controls.Add(typeDescription.userControl);
            card.descriptions.Add(typeDescription.unitDescription);
            lastUnitDescription2 = typeDescription.unitDescription;
        }
    }
}

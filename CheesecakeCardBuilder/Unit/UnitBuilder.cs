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
            typeComboBox.DataSource = Enum.GetValues(typeof(UnitType));
            addDescriptions();
        }

        private void addDescriptions() {
            descriptionComboBox.Items.Add(new TypeDescriptions() { unitDescription = new DefaultUnitDescription(this) });
            descriptionComboBox2.Items.Add(new TypeDescriptions() { unitDescription = new DefaultUnitDescription(this) });
            descriptionComboBox.Items.Add(new TypeDescriptions() { unitDescription = new KeywordUnitDescription(config, this) });
            descriptionComboBox2.Items.Add(new TypeDescriptions() { unitDescription = new KeywordUnitDescription(config, this) });
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

        private async void updateCard() {
            previewPicture.Image = await unitCardRenderer.generate();
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
            updateCard();
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
            updateCard();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            card.type = (UnitType)typeComboBox.SelectedItem;
            updateCard();
        }

        public void loadCard(UnitCard unit) {
            typeComboBox.SelectedItem = unit.type;
            // Insert other here
        }

        private void exportButton_Click(object sender, EventArgs e) {
            exportSaveFileDialog.FileName = String.Join("_", card.name.Split(' ')) + ".png";
            if (exportSaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                previewPicture.Image.Save(exportSaveFileDialog.FileName);
            };
        }

        private void artButton_Click(object sender, EventArgs e) {
            if (artSelectionOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                String filename = artSelectionOpenFileDialog.FileName;
                card.art = new Bitmap(filename);
                updateCard();
            }
        }
    }
}

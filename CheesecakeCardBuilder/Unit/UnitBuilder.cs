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
    using Repository;

    public partial class UnitBuilder : Form, CardUpdater {
        private UnitCard card;
        private UnitCardRenderer unitCardRenderer;
        private ProjectConfig config;
        private UnitDescriptionControl lastUnitDescription;
        private UnitDescriptionControl lastUnitDescription2;
        private CardRepository repository;

        public UnitBuilder(ProjectConfig config) {
            this.config = config;
            this.card = new UnitCard();
            this.unitCardRenderer = new UnitCardRenderer(card, config);
            this.repository = new LiteDBRepository(config);
            InitializeComponent();
            descriptionComboBox.DisplayMember = "name";
            descriptionComboBox2.DisplayMember = "name";
            descriptionComboBox.ValueMember = "type";
            descriptionComboBox2.ValueMember = "type";
            typeComboBox.DataSource = Enum.GetValues(typeof(UnitType));
            addDescriptions();
        }

        private void addDescriptions() {
            descriptionComboBox.Items.Add(new EmptyUnitDescriptionControl(config, this));
            descriptionComboBox2.Items.Add(new EmptyUnitDescriptionControl(config, this));
            descriptionComboBox.Items.Add(new DefaultUnitDescriptionControl(config, this));
            descriptionComboBox2.Items.Add(new DefaultUnitDescriptionControl(config, this));
            descriptionComboBox.Items.Add(new KeywordUnitDescriptionControl(config, this));
            descriptionComboBox2.Items.Add(new KeywordUnitDescriptionControl(config, this));
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

        private void descriptionComboBox_SelectedValueChanged(object sender, EventArgs e) {
            if (lastUnitDescription != null) {
                card.descriptions[0] = new UnitDescription();
                lastUnitDescription.clear();
            }
            if (descriptionComboBox.SelectedItem != null) {
                UnitDescriptionControl typeDescription = (UnitDescriptionControl)descriptionComboBox.SelectedItem;
                descriptionPanel.Controls.Clear();
                descriptionPanel.Controls.Add((UserControl)typeDescription);
                card.descriptions[0] = typeDescription.description;
                lastUnitDescription = typeDescription;
                updateCard();
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e) {
            if (lastUnitDescription2 != null) {
                lastUnitDescription2.clear();
                card.descriptions[1] = new UnitDescription();
            }
            if (descriptionComboBox.SelectedItem != null) {
                UnitDescriptionControl typeDescription = (UnitDescriptionControl)descriptionComboBox2.SelectedItem;
                descriptionPanel2.Controls.Clear();
                descriptionPanel2.Controls.Add((UserControl)typeDescription);
                card.descriptions[1] = typeDescription.description;
                lastUnitDescription2 = typeDescription;
                updateCard();
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            card.unitType = (UnitType)typeComboBox.SelectedItem;
            updateCard();
        }

        public void loadCard(UnitCard unit) {
            typeComboBox.SelectedItem = unit.unitType;
            // Insert other here
        }

        private void exportButton_Click(object sender, EventArgs e) {
            exportSaveFileDialog.FileName = String.Join("_", card.name.Split(' ')) + ".png";
            if (exportSaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                previewPicture.Image.Save(exportSaveFileDialog.FileName);
            };
        }

        private void artButton_Click(object sender, EventArgs e) {
            artSelectionOpenFileDialog.InitialDirectory = config.cardsArtPath;
            if (artSelectionOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                if (artSelectionOpenFileDialog.FileName.Contains(config.cardsArtPath)) {
                    String filename = artSelectionOpenFileDialog.SafeFileName;
                    card.artFile = filename;
                    updateCard();
                } else {
                    MessageBox.Show("Vous devez sélectionner un fichier dans votre répertoire d'art (" + config.cardsArtPath + ")");
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(nameTextBox.Text)) {
                MessageBox.Show("Vous devez spécifier un nom pour votre carte");
            } else {
                repository.save(card);
            }
        }

        private void loadButton_Click(object sender, EventArgs e) {
            CardLoader cardLoader = new CardLoader(repository);
            cardLoader.ShowDialog();
            if (cardLoader.hasSelected) {
                UnitCard newCard = cardLoader.selectedCard;
                nameTextBox.Text = newCard.name;
                resTextbox.Text = newCard.res;
                accTextBox.Text = newCard.acc;
                atkTextBox.Text = newCard.atk;
                defTextBox.Text = newCard.def;
                spdTextbox.Text = newCard.spd;
                typeComboBox.SelectedItem = newCard.unitType;
                descriptionComboBox.Text = newCard.descriptions[0].type.ToString();
                lastUnitDescription.description = newCard.descriptions[0];
                newCard.descriptions[0] = lastUnitDescription.description;
                descriptionComboBox2.Text = newCard.descriptions[1].type.ToString();
                lastUnitDescription2.description = newCard.descriptions[1];
                newCard.descriptions[1] = lastUnitDescription2.description;
                this.unitCardRenderer = new UnitCardRenderer(newCard, config);
                this.card = newCard;
                updateCard();
            }
        }
    }
}

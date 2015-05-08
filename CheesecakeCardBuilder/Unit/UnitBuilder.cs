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
        private CardRepository repository;
        private ComboBox[] descriptionsComboBox;
        private Panel[] descriptionsPanel;
        private UnitDescriptionControl[] lastUnitDescription = new UnitDescriptionControl[2];

        public UnitBuilder(ProjectConfig config) {
            this.config = config;
            this.card = new UnitCard();
            this.unitCardRenderer = new UnitCardRenderer(card, config);
            this.repository = new LiteDBRepository(config);
            InitializeComponent();
            descriptionsComboBox = new ComboBox[] { descriptionComboBox, descriptionComboBox2 };
            descriptionsPanel = new Panel[] { descriptionPanel, descriptionPanel2 };
            typeComboBox.DataSource = Enum.GetValues(typeof(UnitType));
            addDescriptions();
        }

        private void addDescriptions() {
            for (int i = 0; i < card.descriptions.Count(); i++) {
                descriptionsComboBox[i].DisplayMember = "name";
                descriptionsComboBox[i].Tag = i;
                descriptionsComboBox[i].Items.Add(new EmptyUnitDescriptionControl(config, this));
                descriptionsComboBox[i].Items.Add(new DefaultUnitDescriptionControl(config, this));
                descriptionsComboBox[i].Items.Add(new KeywordUnitDescriptionControl(config, this));
                descriptionsComboBox[i].SelectedIndex = 0;
            }
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
            ComboBox descComboBox = (ComboBox)sender;
            int i = (int)descComboBox.Tag;
            if (lastUnitDescription[i] != null) {
                card.descriptions[i] = new UnitDescription();
                lastUnitDescription[i].clear();
            }
            if (descComboBox.SelectedItem != null) {
                UnitDescriptionControl typeDescription = (UnitDescriptionControl)descComboBox.SelectedItem;
                descriptionsPanel[i].Controls.Clear();
                descriptionsPanel[i].Controls.Add((UserControl)typeDescription);
                card.descriptions[i] = typeDescription.description;
                lastUnitDescription[i] = typeDescription;
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
                for (int i = 0; i < newCard.descriptions.Count(); i++) {
                    descriptionsComboBox[i].Text = newCard.descriptions[i].type.ToString();
                    lastUnitDescription[i].description = newCard.descriptions[i];
                    newCard.descriptions[i] = lastUnitDescription[i].description;
                }
                this.unitCardRenderer = new UnitCardRenderer(newCard, config);
                this.card = newCard;
                updateCard();
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e) {

        }
    }
}

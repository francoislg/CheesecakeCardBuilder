using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder.Builders {
    using Config;
    using Unit;
    using Renderer;
    using Repository;

    public partial class CardBuilder : Form, CardUpdater {
        private Card currentCard;
        private CardRenderer cardRenderer;
        private ProjectConfig config;
        private CardRepository repository;
        private bool updateActivated = true;
        private CardControl currentCardControl;
        private List<ComboBoxCardType> cbCardTypes = new List<ComboBoxCardType>();

        private CardBuilderConfig cardBuilderConfig;

        private class ComboBoxCardType {
            public string name {
                get {
                    return card.type;
                }
            }
            public Card card { get; private set; }
            public ComboBoxCardType(Card card) {
                this.card = card;
            }
        }

        public CardBuilder(ProjectConfig config) {
            this.config = config;
            this.repository = new LiteDBRepository(config);
            this.cardBuilderConfig = new CardBuilderConfig(config, this);
            InitializeComponent();
            cbCardTypes.Add(new ComboBoxCardType(new UnitCard()));
            cbCardTypes.Add(new ComboBoxCardType(new StructureCard()));
            cbCardTypes.Add(new ComboBoxCardType(new CasterCard()));
            this.typeComboBox.DisplayMember = "name";
            this.typeComboBox.ValueMember = "name";
            this.typeComboBox.DataSource = cbCardTypes;
            this.typeComboBox.SelectedIndex = 0;
        }

        public void changeCard(Card newCard) {
            Console.WriteLine("CHANGED");
            desactivateUpdates();
            nameTextBox.Text = newCard.name;
            this.typeComboBox.SelectedValue = newCard.type;
            currentCardControl = cardBuilderConfig.getControl(newCard);
            this.cardControlPanel.Controls.Clear();
            this.cardControlPanel.Controls.Add((UserControl)currentCardControl);
            currentCardControl.loadCard(newCard);
            this.cardRenderer = cardBuilderConfig.getRenderer(newCard);
            this.currentCard = newCard;
            activateUpdates();
            updateCard();
        }

        public async void updateCard() {
            if (updateActivated) {
                previewPicture.Image = await cardRenderer.generate();
            }
        }

        private void desactivateUpdates() {
            updateActivated = false;
        }

        private void activateUpdates() {
            updateActivated = true;
        }

        private void exportButton_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(currentCard.name)) {
                MessageBox.Show("Vous devez spécifier un nom pour la carte");
            } else {
                exportSaveFileDialog.FileName = String.Join("_", currentCard.name.Split(' ')) + ".png";
                if (exportSaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    previewPicture.Image.Save(exportSaveFileDialog.FileName);
                };
            }
        }

        private void artButton_Click(object sender, EventArgs e) {
            artSelectionOpenFileDialog.InitialDirectory = config.cardsArtPath;
            if (artSelectionOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                if (artSelectionOpenFileDialog.FileName.Contains(config.cardsArtPath)) {
                    String filename = artSelectionOpenFileDialog.SafeFileName;
                    currentCard.artFile = filename;
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
                repository.save(currentCard);
            }
        }

        private void loadButton_Click(object sender, EventArgs e) {
            CardLoader cardLoader = new CardLoader(repository);
            cardLoader.ShowDialog();
            if (cardLoader.hasSelected) {
                changeCard(cardLoader.selectedCard);
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (updateActivated) {
                ComboBoxCardType type = typeComboBox.SelectedItem as ComboBoxCardType;
                changeCard(type.card);
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e) {
            if (updateActivated) {
                currentCard.name = nameTextBox.Text;
                updateCard();
            }
        }
    }
}

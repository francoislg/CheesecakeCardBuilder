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
        private Card card;
        private CardRenderer cardRenderer;
        private ProjectConfig config;
        private CardRepository repository;
        private bool updateActivated = true;
        private CardControl currentCardControl;

        public UnitBuilder(ProjectConfig config) {
            this.config = config;
            this.card = new UnitCard();
            this.cardRenderer = new UnitCardRenderer(card, config);
            this.repository = new LiteDBRepository(config);
            InitializeComponent();
            changeCardType();
        }

        public void changeCardType() {
            currentCardControl = new UnitCardControl(config, (UnitCard)card, this);
            this.cardControlPanel.Controls.Clear();
            this.cardControlPanel.Controls.Add((UserControl)currentCardControl);
        }

        public void updateCardDescription() {
            updateCard();
        }

        private void event_UpdatePicture(object sender, EventArgs e) {
            card.name = nameTextBox.Text;
            updateCard();
        }

        private async void updateCard() {
            if (updateActivated) {
                previewPicture.Image = await cardRenderer.generate();
            }
        }

        private void desactivateUpdates() {
            updateActivated = false;
            /*nameTextBox.TextChanged -= event_UpdatePicture;
            hpTextbox.TextChanged -= event_UpdatePicture;
            resTextbox.TextChanged -= event_UpdatePicture;
            atkTextBox.TextChanged -= event_UpdatePicture;
            defTextBox.TextChanged -= event_UpdatePicture;
            accTextBox.TextChanged -= event_UpdatePicture;
            spdTextbox.TextChanged -= event_UpdatePicture;
            typeComboBox.SelectedIndexChanged -= typeComboBox_SelectedIndexChanged;
            
            for (int i = 0; i < descriptionsComboBox.Count(); i++) {
                descriptionsComboBox[i].SelectedValueChanged -= descriptionComboBox_SelectedValueChanged;
            }*/
        }

        private void activateUpdates() {
            updateActivated = true;
            /*nameTextBox.TextChanged += event_UpdatePicture;
            hpTextbox.TextChanged += event_UpdatePicture;
            resTextbox.TextChanged += event_UpdatePicture;
            atkTextBox.TextChanged += event_UpdatePicture;
            defTextBox.TextChanged += event_UpdatePicture;
            accTextBox.TextChanged += event_UpdatePicture;
            spdTextbox.TextChanged += event_UpdatePicture;
            typeComboBox.SelectedIndexChanged += typeComboBox_SelectedIndexChanged;

            for (int i = 0; i < descriptionsComboBox.Count(); i++) {
                descriptionsComboBox[i].SelectedValueChanged += descriptionComboBox_SelectedValueChanged;
            }*/
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
                loadCard(cardLoader.selectedCard);
            }
        }


        public void loadCard(Card newCard) {
            desactivateUpdates();
            nameTextBox.Text = newCard.name;
            this.card = newCard;
            this.currentCardControl.loadCard(newCard);
            this.cardRenderer = new UnitCardRenderer(card, config);
            activateUpdates();
            updateCard();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}

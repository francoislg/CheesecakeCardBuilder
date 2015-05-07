﻿using System;
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
        private class TypeDescriptions {
            public UserControl userControl {
                get {
                    return (UserControl)unitDescriptionControl;
                }
            }
            public String text {
                get {
                    return unitDescription.name;
                }
            }
            public UnitDescription unitDescription {
                get {
                    return unitDescriptionControl.description;
                }
            }
            public UnitDescriptionControl unitDescriptionControl { get; set; }
        }

        private UnitCard card;
        private UnitCardRenderer unitCardRenderer;
        private ProjectConfig config;
        private TypeDescriptions lastUnitDescription;
        private TypeDescriptions lastUnitDescription2;
        private CardRepository repository;

        public UnitBuilder(ProjectConfig config) {
            this.config = config;
            this.card = new UnitCard();
            this.unitCardRenderer = new UnitCardRenderer(card, config);
            this.repository = new LiteDBRepository(config);
            InitializeComponent();
            descriptionComboBox.DisplayMember = "text";
            descriptionComboBox2.DisplayMember = "text";
            typeComboBox.DataSource = Enum.GetValues(typeof(UnitType));
            addDescriptions();
        }

        private void addDescriptions() {
            descriptionComboBox.Items.Add(new TypeDescriptions() { unitDescriptionControl = new DefaultUnitDescriptionControl(this) });
            descriptionComboBox2.Items.Add(new TypeDescriptions() { unitDescriptionControl = new DefaultUnitDescriptionControl(this) });
            descriptionComboBox.Items.Add(new TypeDescriptions() { unitDescriptionControl = new KeywordUnitDescriptionControl(config, this) });
            descriptionComboBox2.Items.Add(new TypeDescriptions() { unitDescriptionControl = new KeywordUnitDescriptionControl(config, this) });
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
                card.descriptions.Remove(lastUnitDescription.unitDescription);
            }
            TypeDescriptions typeDescription = (TypeDescriptions)descriptionComboBox.SelectedItem;
            descriptionPanel.Controls.Clear();
            descriptionPanel.Controls.Add(typeDescription.userControl);
            card.descriptions.Add(typeDescription.unitDescription);
            lastUnitDescription = typeDescription;
            updateCard();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (lastUnitDescription2 != null) {
                card.descriptions.Remove(lastUnitDescription2.unitDescription);
            }
            TypeDescriptions typeDescription = (TypeDescriptions)descriptionComboBox2.SelectedItem;
            descriptionPanel2.Controls.Clear();
            descriptionPanel2.Controls.Add(typeDescription.userControl);
            card.descriptions.Add(typeDescription.unitDescription);
            lastUnitDescription2 = typeDescription;
            updateCard();
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
                this.unitCardRenderer = new UnitCardRenderer(newCard, config);
                nameTextBox.Text = newCard.name;
                resTextbox.Text = newCard.res;
                accTextBox.Text = newCard.acc;
                atkTextBox.Text = newCard.atk;
                defTextBox.Text = newCard.def;
                spdTextbox.Text = newCard.spd;
                typeComboBox.SelectedItem = newCard.unitType;
                if (newCard.descriptions.Count >= 1) {
                    descriptionComboBox.SelectedValue = newCard.descriptions[0].type;
                    lastUnitDescription.unitDescription.description = newCard.descriptions[0].description;
                }
                this.card = newCard;
                updateCard();
            }
        }
    }
}

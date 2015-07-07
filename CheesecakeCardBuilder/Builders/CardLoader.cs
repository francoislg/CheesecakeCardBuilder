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
    using Repository;
    using CheesecakeCardBuilder.Unit;
    using CheesecakeCardBuilder.Structure;

    public partial class CardLoader : Form {
        private CardRepository repository;
        private List<UnitCard> unitCards;
        private List<StructureCard> structureCards;
        private bool flagSelected = false;
        public bool hasSelected {
            get {
                return flagSelected;
            }
        }
        public Card selectedCard { get; private set; }

        public CardLoader(CardRepository repository) {
            InitializeComponent();
            unitCards = repository.getAllUnitCards();
            structureCards = repository.getAllStructureCards();
            this.repository = repository;
        }

        private void CardLoader_Load(object sender, EventArgs e) {
            unitListBox.Items.AddRange(unitCards.ToArray());
            unitListBox.DisplayMember = "name";
            structureListBox.Items.AddRange(structureCards.ToArray());
            structureListBox.DisplayMember = "name";
        }

        private void structureSearchbox_TextChanged(object sender, EventArgs e) {
            structureListBox.Items.Clear();
            structureListBox.Items.AddRange(
                structureCards.Where(x => x.name.ToLower().Contains(structureListBox.Text.ToLower())).ToArray()
            );
        }

        private void unitSearchBox_TextChanged(object sender, EventArgs e) {
            unitListBox.Items.Clear();
            unitListBox.Items.AddRange(
                unitCards.Where(x => x.name.ToLower().Contains(unitSearchBox.Text.ToLower())).ToArray()
            );
        }

        private void cardsListBox_MouseDoubleClick(object sender, MouseEventArgs e) {
            selectedCard = unitListBox.SelectedItem as UnitCard;
            if (selectedCard != null) {
                flagSelected = true;
            }
            this.Close();
        }

        private void structureListbox_DoubleClick(object sender, EventArgs e) {
            selectedCard = structureListBox.SelectedItem as StructureCard;
            if (selectedCard != null) {
                flagSelected = true;
            }
            this.Close();
        }
    }
}

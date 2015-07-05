using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder.Unit {
    using Config;
    using Repository;

    public partial class CardLoader : Form {
        private CardRepository repository;
        private List<UnitCard> cards;
        private bool flagSelected = false;
        public bool hasSelected {
            get {
                return flagSelected;
            }
        }
        public Card selectedCard {
            get{
                return (Card)cardsListBox.SelectedItem;
            }
        }

        public CardLoader(CardRepository repository) {
            InitializeComponent();
            cards = repository.getAllUnitCards();
            this.repository = repository;
        }

        private void CardLoader_Load(object sender, EventArgs e) {
            cardsListBox.Items.AddRange(cards.ToArray());
            cardsListBox.DisplayMember = "name";
        }

        private void cardsListBox_MouseDoubleClick(object sender, MouseEventArgs e) {
            flagSelected = true;
            this.Close();
        }

        private void searchBox_TextChanged(object sender, EventArgs e) {
            cardsListBox.Items.Clear();
            cardsListBox.Items.AddRange(
                cards.Where(x => x.name.ToLower().Contains(searchBox.Text.ToLower())).ToArray()
            );
        }
    }
}

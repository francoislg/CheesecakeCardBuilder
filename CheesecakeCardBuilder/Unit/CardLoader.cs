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
        public UnitCard selectedCard {
            get{
                return (UnitCard)cardsListBox.SelectedItem;
            }
        }

        public CardLoader(CardRepository repository) {
            InitializeComponent();
            this.repository = repository;
        }

        private void CardLoader_Load(object sender, EventArgs e) {
            List<UnitCard> cards = repository.getAllUnitCards();
            cardsListBox.DataSource = cards;
            cardsListBox.DisplayMember = "name";
        }

        private void cardsListBox_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.Close();
        }
    }
}

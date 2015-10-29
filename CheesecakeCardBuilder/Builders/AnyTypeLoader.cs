using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder.Builders {
    public partial class AnyTypeLoader<T> : UserControl, TypeLoader where T : Card, new() {
        private List<T> listCards;
        private CardLoader cardLoader;
        public AnyTypeLoader(List<T> list, CardLoader cardLoader) {
            this.listCards = list;
            this.cardLoader = cardLoader;
            InitializeComponent();
        }

        private void TypeLoader_Load(object sender, EventArgs e) {
            addItems(listCards);
            listBox.DisplayMember = "name";
        }

        private void searchBox_TextChanged(object sender, EventArgs e) {
            listBox.Items.Clear();
            addItems(
                listCards.Where(x => x.name.ToLower().Contains(searchBox.Text.ToLower())).ToList<T>()
            );
        }

        private void addItems(List<T> items) {
            listBox.Items.Clear();
            items.ForEach(x => listBox.Items.Add(x));
        }

        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e) {
            cardLoader.finish((T)listBox.SelectedItem);
        }
    }
}

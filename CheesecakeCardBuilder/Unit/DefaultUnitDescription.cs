using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder.Unit {
    public partial class DefaultUnitDescription : UserControl, UnitDescription {
        public List<CardUpdater> cardUpdaters = new List<CardUpdater>();
        public DefaultUnitDescription(CardUpdater updater) {
            addUpdater(updater);
            InitializeComponent();
        }

        public String name { get { return "Default"; } }
        public String description {
            get {
                return whenBox.Text + " " + targetBox.Text + " " + actionBox.Text;
            }
        }

        public void addUpdater(CardUpdater updater) {
            cardUpdaters.Add(updater);
        }

        private void actionBox_KeyUp(object sender, KeyEventArgs e) {
            cardUpdaters.ForEach(updater => updater.updateCardDescription());
        }
    }
}

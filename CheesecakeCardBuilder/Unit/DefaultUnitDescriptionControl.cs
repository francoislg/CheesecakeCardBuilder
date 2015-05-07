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
    public partial class DefaultUnitDescriptionControl : UserControl, UnitDescriptionControl {
        public List<CardUpdater> cardUpdaters = new List<CardUpdater>();
        private DefaultUnitDescription unitDesc;
        public DefaultUnitDescriptionControl(CardUpdater updater) {
            addUpdater(updater);
            unitDesc = new DefaultUnitDescription();
            InitializeComponent();
        }

        public UnitDescription description {
            get {
                return unitDesc;
            }
        }

        public String name {
            get {
                return unitDesc.name;
            }
        }

        public void addUpdater(CardUpdater updater) {
            cardUpdaters.Add(updater);
        }

        private void actionBox_KeyUp(object sender, KeyEventArgs e) {
            unitDesc.description = new String[] { whenBox.Text, targetBox.Text, actionBox.Text };
            cardUpdaters.ForEach(updater => updater.updateCardDescription());
        }
    }
}

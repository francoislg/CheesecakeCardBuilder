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
        public DefaultUnitDescription() {
            InitializeComponent();
        }

        public String name { get { return "Default"; } }
        public String description {
            get {
                return whenBox.Text + " " + targetBox.Text + " " + actionBox.Text;
            }
        }
    }
}

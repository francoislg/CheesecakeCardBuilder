using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheesecakeCardBuilder.Config;

namespace CheesecakeCardBuilder.Unit {
    public partial class DefaultUnitDescriptionControl : UserControl, UnitDescriptionControl {
        private CardUpdater updater;
        private DefaultUnitDescription unitDesc;

        public String name {
            get {
                return unitDesc.name;
            }
        }

        public UnitDescriptionType type {
            get {
                return unitDesc.type;
            }
        }

        public UnitDescription description {
            get {
                return unitDesc;
            }
            set {
                unitDesc.description = value.description;
                whenBox.Text = value.description[0].TrimEnd(',');
                targetBox.Text = value.description[1];
                actionBox.Text = value.description[2];
            }
        }

        public DefaultUnitDescriptionControl(ProjectConfig config, CardUpdater updater) {
            InitializeComponent();
            this.unitDesc = new DefaultUnitDescription();
            this.updater = updater;
        }

        public void clear() {
            whenBox.Text = "";
            targetBox.Text = "";
            actionBox.Text = "";
        }

        private void actionBox_KeyUp(object sender, KeyEventArgs e) {
            description.description = new String[] { whenBox.Text + ",", targetBox.Text, actionBox.Text };
            updater.updateCardDescription();
        }
    }
}

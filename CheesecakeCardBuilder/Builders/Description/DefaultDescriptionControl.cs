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

namespace CheesecakeCardBuilder.Builders.Description {
    using Description;
    using CheesecakeCardBuilder.Description;
    public partial class DefaultDescriptionControl : UserControl, DescriptionControl {
        private CardUpdater updater;
        private DefaultDescription unitDesc;

        public String name {
            get {
                return unitDesc.name;
            }
        }

        public DescriptionType typeDescription {
            get {
                return unitDesc.type;
            }
        }

        public CardDescription cardDescription {
            get {
                return unitDesc;
            }
            set {
                unitDesc.description = value.description;
                if (value.description.Count() > 0) {
                    whenBox.Text = value.description[1].TrimEnd(',');
                    targetBox.Text = value.description[2];
                    actionBox.Text = value.description[3];
                }
            }
        }

        public DefaultDescriptionControl(ProjectConfig config, CardUpdater updater) {
            InitializeComponent();
            this.unitDesc = new DefaultDescription();
            this.updater = updater;
        }

        public void clear() {
            whenBox.Text = "";
            targetBox.Text = "";
            actionBox.Text = "";
        }

        private void actionBox_KeyUp(object sender, KeyEventArgs e) {
            cardDescription.description = new String[] { "Special :", whenBox.Text + ",", targetBox.Text, actionBox.Text };
            updater.updateCard();
        }
    }
}

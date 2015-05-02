using System;
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

    public partial class UnitBuilder : Form {
        private ProjectConfig config;
        private class TypeDescriptions {
            public UserControl userControl {
                get {
                    return (UserControl)description;
                }
            }
            public String text {
                get {
                    return description.name;
                }
            }
            private UnitDescription description;
            public UnitDescription unitDescription { 
                set {
                    description = value;
                }
            }
        }

        public UnitBuilder(ProjectConfig config) {
            this.config = config;
            InitializeComponent();
            descriptionComboBox.Items.Add(new TypeDescriptions() { unitDescription = new DefaultUnitDescription() });
            descriptionComboBox.DisplayMember = "text";
        }

        private void descriptionComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            TypeDescriptions typeDescription = (TypeDescriptions)descriptionComboBox.SelectedItem;
            descriptionPanel.Controls.Clear();
            descriptionPanel.Controls.Add(typeDescription.userControl);
        }
    }
}

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
    using Config;
    public partial class KeywordUnitDescriptionControl : UserControl, UnitDescriptionControl {
        private KeywordUnitDescription unitDesc;
        private CardUpdater updater;

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
                keywordComboBox.Text = value.description[0];
            }
        }

        public KeywordUnitDescriptionControl(ProjectConfig config, CardUpdater updater) {
            InitializeComponent();
            this.updater = updater;
            this.unitDesc = new KeywordUnitDescription();
            keywordComboBox.DataSource = config.keywords;
        }

        public void clear() {
            keywordComboBox.SelectedIndex = 0;
        }

        private void keywordComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            unitDesc.description = new String[] { keywordComboBox.SelectedItem.ToString() };
            updater.updateCardDescription();
        }
    }
}

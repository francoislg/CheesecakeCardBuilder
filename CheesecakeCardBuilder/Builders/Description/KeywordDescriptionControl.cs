using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder.Builders.Description {
    using Config;
    using Description;
    using CheesecakeCardBuilder.Unit;
    using CheesecakeCardBuilder.Description;
    public partial class KeywordDescriptionControl : UserControl, DescriptionControl {
        private KeywordDescription unitDesc;
        private CardUpdater updater;

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
                keywordComboBox.Text = value.description[0];
            }
        }

        public KeywordDescriptionControl(ProjectConfig config, CardUpdater updater) {
            InitializeComponent();
            this.updater = updater;
            this.unitDesc = new KeywordDescription();
            keywordComboBox.DataSource = config.keywords;
        }

        public void clear() {
            keywordComboBox.SelectedIndex = 0;
        }

        private void keywordComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            unitDesc.description = new String[] { keywordComboBox.SelectedItem.ToString() };
            updater.updateCard();
        }
    }
}

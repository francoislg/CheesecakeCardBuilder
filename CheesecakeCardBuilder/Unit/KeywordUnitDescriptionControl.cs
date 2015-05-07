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
        public List<CardUpdater> cardUpdaters = new List<CardUpdater>();
        private KeywordUnitDescription unitDesc;

        public String name {
            get {
                return unitDesc.name;
            }
        }

        public UnitDescription description {
            get {
                return unitDesc;
            }
        }

        public KeywordUnitDescriptionControl(ProjectConfig config, CardUpdater updater) {
            addUpdater(updater);
            unitDesc = new KeywordUnitDescription();
            InitializeComponent();
            keywordComboBox.DataSource = config.keywords;
        }

        public void addUpdater(CardUpdater updater) {
            cardUpdaters.Add(updater);
        }

        private void keywordComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            unitDesc.description = new String[] { keywordComboBox.SelectedItem.ToString() };
            update();
        }

        private void update() {
            cardUpdaters.ForEach(updater => updater.updateCardDescription());
        }
    }
}

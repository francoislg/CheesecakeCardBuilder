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
    public partial class KeywordUnitDescription : UserControl, UnitDescription {
        public List<CardUpdater> cardUpdaters = new List<CardUpdater>();
        public KeywordUnitDescription(ProjectConfig config, CardUpdater updater) {
            addUpdater(updater);
            InitializeComponent();
            keywordComboBox.DataSource = config.keywords;
        }

        public UnitDescriptionType type {
            get {
                return UnitDescriptionType.Keyword;
            }
        }
        public String name { get { return "Keyword"; } }
        private Object selectedItem;
        public String description {
            get {
                return selectedItem.ToString();
            }
        }

        public void addUpdater(CardUpdater updater) {
            cardUpdaters.Add(updater);
        }

        private void keywordComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            selectedItem = keywordComboBox.SelectedItem;
            update();
        }

        private void update() {
            cardUpdaters.ForEach(updater => updater.updateCardDescription());
        }
    }
}

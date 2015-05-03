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
    public partial class KeywordUnitDescription : UserControl, UnitDescription {
        public List<CardUpdater> cardUpdaters = new List<CardUpdater>();
        public KeywordUnitDescription(CardUpdater updater) {
            addUpdater(updater);
            InitializeComponent();
            keywordComboBox.DataSource = Enum.GetValues(typeof(Keyword));
        }

        public UnitDescriptionType type {
            get {
                return UnitDescriptionType.Keyword;
            }
        }
        public String name { get { return "Keyword"; } }
        public String description {
            get {
                if (keywordComboBox.SelectedItem == null) {
                    return "";
                }
                Keyword keyword = (Keyword)keywordComboBox.SelectedItem;
                return keyword.ToString();
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

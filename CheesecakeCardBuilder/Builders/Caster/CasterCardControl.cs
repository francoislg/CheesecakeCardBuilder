using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder.Builders.Caster {
    using CheesecakeCardBuilder.Config;
    public partial class CasterCardControl : UserControl, CardControl {
        private ProjectConfig config;
        private CasterCard casterCard = new CasterCard();
        private CardUpdater updater;
        public CasterCardControl(ProjectConfig config, CardUpdater updater) {
            this.config = config;
            this.updater = updater;
            InitializeComponent();
        }

        public void loadCard(Card card) {
            CasterCard newCard = card as CasterCard;
            resTextbox.DataBindings.Add("Text", newCard, "res", false, DataSourceUpdateMode.OnPropertyChanged);
            this.casterCard = newCard;
        }

        private void resTextbox_TextChanged(object sender, EventArgs e) {
            updater.updateCard();
        }
    }
}

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
using CheesecakeCardBuilder.Builders.Description;
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
            for (int i = 0; i < newCard.descriptions.Count(); i++) {
                CardDescriptionContainer container = new CardDescriptionContainer(newCard, i);
                descriptionsPanel.Controls.Add(new DescriptionSelectorControl(getNewDescriptionControls(), updater, container));
            }
            this.casterCard = newCard;
        }

        private List<UserControl> getNewDescriptionControls() {
            List<UserControl> descriptionControls = new List<UserControl>();
            descriptionControls.Add(new DefaultDescriptionControl(config, updater));
            return descriptionControls;
        }

        private void resTextbox_TextChanged(object sender, EventArgs e) {
            updater.updateCard();
        }
    }
}

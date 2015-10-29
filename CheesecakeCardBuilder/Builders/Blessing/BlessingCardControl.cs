using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder.Builders.Blessing {
    using CheesecakeCardBuilder.Config;
using CheesecakeCardBuilder.Builders.Description;
    public partial class BlessingCardControl : UserControl, CardControl {
        private ProjectConfig config;
        private BlessingCard blessingCard = new BlessingCard();
        private CardUpdater updater;
        public BlessingCardControl(ProjectConfig config, CardUpdater updater) {
            this.config = config;
            this.updater = updater;
            InitializeComponent();
        }

        public void loadCard(Card card) {
            BlessingCard newCard = card as BlessingCard;
            resTextBox.DataBindings.Add("Text", newCard, "res", false, DataSourceUpdateMode.OnPropertyChanged);
            for (int i = 0; i < newCard.descriptions.Count(); i++) {
                CardDescriptionContainer container = new CardDescriptionContainer(newCard, i);
                descriptionsPanel.Controls.Add(new DescriptionSelectorControl(getNewDescriptionControls(), updater, container));
            }
            this.blessingCard = newCard;
        }

        private List<UserControl> getNewDescriptionControls() {
            List<UserControl> descriptionControls = new List<UserControl>();
            descriptionControls.Add(new DefaultDescriptionControl(config, updater));
            return descriptionControls;
        }

        private void resTextBox_TextChanged(object sender, EventArgs e) {
            updater.updateCard();
        }
    }
}

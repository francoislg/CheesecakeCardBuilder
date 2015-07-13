using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder.Builders.Location {
    using CheesecakeCardBuilder.Config;
using CheesecakeCardBuilder.Builders.Description;
    public partial class LocationCardControl : UserControl, CardControl {
        private ProjectConfig config;
        private LocationCard locationCard = new LocationCard();
        private CardUpdater updater;
        public LocationCardControl(ProjectConfig config, CardUpdater updater) {
            this.config = config;
            this.updater = updater;
            InitializeComponent();
        }

        public void loadCard(Card card) {
            LocationCard newCard = card as LocationCard;
            prodSpeedTextBox.DataBindings.Add("Text", newCard, "productionSpeed", false, DataSourceUpdateMode.OnPropertyChanged);
            lifespanTextBox.DataBindings.Add("Text", newCard, "lifespan", false, DataSourceUpdateMode.OnPropertyChanged);
            rareCheckbox.DataBindings.Add("Checked", newCard, "rare", false, DataSourceUpdateMode.OnPropertyChanged);
            for (int i = 0; i < newCard.descriptions.Count(); i++) {
                CardDescriptionContainer container = new CardDescriptionContainer(newCard, i);
                descriptionsPanel.Controls.Add(new DescriptionSelectorControl(getNewDescriptionControls(), updater, container));
            }
            this.locationCard = newCard;
        }

        private List<UserControl> getNewDescriptionControls() {
            List<UserControl> descriptionControls = new List<UserControl>();
            descriptionControls.Add(new DefaultDescriptionControl(config, updater));
            return descriptionControls;
        }

        private void lifespanTextBox_TextChanged(object sender, EventArgs e) {
            updater.updateCard();
        }
    }
}

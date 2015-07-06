using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder.Builders.Structure {
    using CheesecakeCardBuilder.Structure;
    using CheesecakeCardBuilder.Config;
    using CheesecakeCardBuilder.Builder;
    public partial class StructureCardControl : UserControl, CardControl {
        private ProjectConfig config;
        private StructureCard structureCard = new StructureCard();
        private CardUpdater updater;
        private DescriptionControl[] lastUnitDescription = new DescriptionControl[2];

        public StructureCardControl(ProjectConfig config, CardUpdater updater) {
            this.config = config;
            this.updater = updater;
            InitializeComponent();
            typeComboBox.DataSource = Enum.GetValues(typeof(StructureType));
        }

        public void loadCard(Card card) {
            StructureCard newCard = card as StructureCard;
            this.structureCard = newCard;
        }

        private void typeCombobox_SelectedIndexChanged(object sender, EventArgs e) {
            structureCard.structureType = (StructureType)typeComboBox.SelectedItem;
            updater.updateCard();
        }
    }
}

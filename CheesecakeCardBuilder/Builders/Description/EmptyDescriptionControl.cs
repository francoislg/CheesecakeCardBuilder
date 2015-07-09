using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheesecakeCardBuilder.Config;

namespace CheesecakeCardBuilder.Builders.Description {
    using CheesecakeCardBuilder.Unit;
    using Description;
    using CheesecakeCardBuilder.Description;
    public partial class EmptyDescriptionControl : UserControl, DescriptionControl {
        private CardUpdater updater;
        private EmptyCardDescription unitDesc;

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
            }
        }

        public EmptyDescriptionControl(ProjectConfig config, CardUpdater updater) {
            InitializeComponent();
            this.unitDesc = new EmptyCardDescription();
            this.updater = updater;
        }

        public void clear() {
            
        }
    }
}

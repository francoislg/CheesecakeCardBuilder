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

namespace CheesecakeCardBuilder.Builders.Unit {
    using CheesecakeCardBuilder.Unit;
    using Description;
    public partial class EmptyUnitDescriptionControl : UserControl, DescriptionControl {
        private CardUpdater updater;
        private EmptyCardDescription unitDesc;

        public String name {
            get {
                return unitDesc.name;
            }
        }

        public DescriptionType type {
            get {
                return unitDesc.type;
            }
        }

        public CardDescription description {
            get {
                return unitDesc;
            }
            set {
                unitDesc.description = value.description;
            }
        }

        public EmptyUnitDescriptionControl(ProjectConfig config, CardUpdater updater) {
            InitializeComponent();
            this.unitDesc = new EmptyCardDescription();
            this.updater = updater;
        }

        public void clear() {
            
        }
    }
}

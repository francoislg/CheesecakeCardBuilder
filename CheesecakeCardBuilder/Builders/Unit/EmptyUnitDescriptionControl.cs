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

namespace CheesecakeCardBuilder.Builder.Unit {
    using CheesecakeCardBuilder.Unit;
    public partial class EmptyUnitDescriptionControl : UserControl, UnitDescriptionControl {
        private CardUpdater updater;
        private UnitDescription unitDesc;

        public String name {
            get {
                return unitDesc.name;
            }
        }

        public UnitDescriptionType type {
            get {
                return unitDesc.type;
            }
        }

        public UnitDescription description {
            get {
                return unitDesc;
            }
            set {
                unitDesc.description = value.description;
            }
        }

        public EmptyUnitDescriptionControl(ProjectConfig config, CardUpdater updater) {
            InitializeComponent();
            this.unitDesc = new UnitDescription();
            this.updater = updater;
        }

        public void clear() {
            
        }
    }
}

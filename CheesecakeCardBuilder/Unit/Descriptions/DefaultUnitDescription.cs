using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Unit {
    public class DefaultUnitDescription : UnitDescription {
        public DefaultUnitDescription() {
            this.name = "Default";
            this.type = UnitDescriptionType.Default;
        }
    }
}

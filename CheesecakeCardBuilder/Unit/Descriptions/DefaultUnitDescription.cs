using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Unit {
    public class DefaultUnitDescription : CardDescription {
        public DefaultUnitDescription() {
            this.name = "Default";
            this.type = DescriptionType.Default;
        }
    }
}

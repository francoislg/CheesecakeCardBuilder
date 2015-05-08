using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Unit {
    public class UnitDescription {
        public UnitDescriptionType type { get; set; }
        public String name { get; set; }
        public String[] description { get; set; }

        public UnitDescription() {
            this.name = "Empty";
            this.type = UnitDescriptionType.Empty;
            this.description = new String[] { };
        }
    }
}

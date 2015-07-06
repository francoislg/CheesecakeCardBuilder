using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder {
    public class CardDescription {
        public DescriptionType type { get; set; }
        public String name { get; set; }
        public String[] description { get; set; }

        public CardDescription() {
            this.name = "Empty";
            this.type = DescriptionType.Empty;
            this.description = new String[] { };
        }
    }
}

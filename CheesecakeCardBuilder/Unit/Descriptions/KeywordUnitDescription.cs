using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Unit {
    public class KeywordUnitDescription : CardDescription {
        public KeywordUnitDescription() {
            this.name = "Keyword";
            this.type = DescriptionType.Keyword;
        }
    }
}

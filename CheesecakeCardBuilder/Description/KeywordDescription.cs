using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Description {
    public class KeywordDescription : CardDescription {
        public KeywordDescription() {
            this.name = "Keyword";
            this.type = DescriptionType.Keyword;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Description {
    public class DefaultDescription : CardDescription {
        public DefaultDescription() {
            this.name = "Default";
            this.type = DescriptionType.Default;
        }
    }
}

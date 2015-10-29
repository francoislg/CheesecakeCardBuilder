using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder {
    public interface Card {
        string name { get; set; }
        string res { get; set; }
        string artFile { get; set; }
        bool rare { get; set; }
        string type { get; }
        CardDescription[] descriptions { get; set; }
    }
}

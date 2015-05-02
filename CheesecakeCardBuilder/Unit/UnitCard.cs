using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Unit {
    public class UnitCard {
        public String name { get; set; }
        public String hp { get; set; }
        public String res { get; set; }
        public String atk { get; set; }
        public String def { get; set; }
        public String spd { get; set; }
        public String acc { get; set; }
        public List<UnitDescription> descriptions { get; set; }

        public UnitCard() {
            descriptions = new List<UnitDescription>();
        }
    }
}

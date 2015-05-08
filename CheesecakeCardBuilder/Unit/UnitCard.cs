using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Unit {
    using LiteDB;
    using System.Drawing;
    public class UnitCard {
        [BsonId]
        public String name { get; set; }
        public String hp { get; set; }
        public String res { get; set; }
        public String atk { get; set; }
        public String def { get; set; }
        public String spd { get; set; }
        public String acc { get; set; }
        public UnitType unitType { get; set; }
        public String artFile { get; set; }
        public UnitDescription[] descriptions { get; set; }

        public UnitCard() {
            artFile = "template.png";
            descriptions = new UnitDescription[] { new UnitDescription(), new UnitDescription() };
        }
    }
}

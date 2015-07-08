using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder {
    using LiteDB;
    using System.Drawing;
    using Unit;
    public class UnitCard : Card {
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
        public CardDescription[] descriptions { get; set; }
        public string type {
            get {
                return "Unit";
            }
        }

        public UnitCard() {
            artFile = "template.png";
            hp = "";
            res = "";
            atk = "";
            def = "";
            spd = "";
            acc = "";
            unitType = UnitType.Standard;
            descriptions = new CardDescription[] { new CardDescription(), new CardDescription() };
        }
    }
}

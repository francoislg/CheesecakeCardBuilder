using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder {
    using CheesecakeCardBuilder.Gear;
using LiteDB;
    public class GearCard : Card {
        [BsonId]
        public String name { get; set; }
        public String res { get; set; }
        public String artFile { get; set; }
        public String atk { get; set; }
        public String def { get; set; }
        public bool rare { get; set; }
        public GearType gearType { get; set; }
        public CardDescription[] descriptions { get; set; }
        public List<string> tags { get; set; }
        public string type {
            get {
                return "Gear";
            }
        }

        public GearCard() {
            artFile = "template.png";
            atk = "";
            def = "";
            res = "";
            rare = false;
            descriptions = new CardDescription[] { new CardDescription() };
            tags = new List<string>();
        }
    }
}

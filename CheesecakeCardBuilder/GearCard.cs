using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder {
    using LiteDB;
    public class GearCard : Card {
        [BsonId]
        public String name { get; set; }
        public String res { get; set; }
        public String artFile { get; set; }
        public String atk { get; set; }
        public String def { get; set; }
        public CardDescription[] descriptions { get; set; }
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
            descriptions = new CardDescription[] { new CardDescription() };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder {
    using LiteDB;
    public class CasterCard : Card {
        [BsonId]
        public String name { get; set; }
        public String res { get; set; }
        public String artFile { get; set; }
        public CardDescription[] descriptions { get; set; }

        public CasterCard() {
            artFile = "template.png";
            res = "";
            descriptions = new CardDescription[] { new CardDescription() };
        }
    }
}

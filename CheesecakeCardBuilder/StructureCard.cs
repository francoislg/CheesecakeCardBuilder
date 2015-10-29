using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder {
    using LiteDB;
    using Structure;
    public class StructureCard : Card {
        [BsonId]
        public String name { get; set; }
        public String res { get; set; }
        public String artFile { get; set; }
        public String prod { get; set; }
        public String storSpeed { get; set; }
        public String storage { get; set; }
        public bool rare { get; set; }
        public CardDescription[] descriptions { get; set; }
        public List<string> tags { get; set; }
        public StructureType structureType { get; set; }
        public string type {
            get {
                return "Structure";
            }
        }

        public StructureCard() {
            artFile = "template.png";
            res = "";
            prod = "";
            storSpeed = "";
            storage = "";
            rare = false;
            descriptions = new CardDescription[] { new CardDescription() };
            tags = new List<string>();
            structureType = StructureType.Production;
        }
    }
}

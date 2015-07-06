﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Structure {
    using LiteDB;
    public class StructureCard : Card {
        [BsonId]
        public String name { get; set; }
        public String res { get; set; }
        public String artFile { get; set; }
        public String prod { get; set; }
        public String storSpeed { get; set; }
        public String maxCapacity { get; set; }
        public CardDescription[] descriptions { get; set; }

        public StructureCard() {
            artFile = "template.png";
            res = "";
            prod = "";
            storSpeed = "";
            maxCapacity = "";
            descriptions = new CardDescription[] { new CardDescription(), new CardDescription() };
        }
    }
}

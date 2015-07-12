﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder {
    using LiteDB;
    public class LocationCard : Card {
        [BsonId]
        public String name { get; set; }
        public String res {
            get {
                return "";
            }
            set {}
        }
        public String productionSpeed { get; set; }
        public String lifespan { get; set; }
        public String artFile { get; set; }
        public CardDescription[] descriptions { get; set; }
        public string type {
            get {
                return "Location";
            }
        }

        public LocationCard() {
            artFile = "template.png";
            productionSpeed = "";
            lifespan = "";
            descriptions = new CardDescription[] { new CardDescription() };
        }
    }
}

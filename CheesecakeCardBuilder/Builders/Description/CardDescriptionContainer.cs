using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Builders.Description {
    public class CardDescriptionContainer {
        private Card card;
        private int position;
        public DescriptionType type {
            get {
                return this.card.descriptions[position].type;
            }
        }
        public CardDescription description {
            get {
                return this.card.descriptions[position];
            }
            set {
                this.card.descriptions[position] = value;
            }
        }
        public CardDescriptionContainer(Card card, int position) {
            this.card = card;
            this.position = position;
        }
    }
}

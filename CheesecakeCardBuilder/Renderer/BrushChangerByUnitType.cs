using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer {
    using CardParts;
    using System.Drawing;
    using CheesecakeCardBuilder.Unit;

    public class BrushChangerByUnitType : ByTypeHandler<UnitType, Brush>, BrushChangerByType {
        private Card card;

        public BrushChangerByUnitType(Card card) {
            this.card = card;
        }

        public BrushChangerByUnitType(Card card, Brush defaultBrush)
            : base(defaultBrush) {
            this.card = card;
        }

        public void update(TextRenderer renderer) {
            if (card is UnitCard) {
                UnitCard unitCard = card as UnitCard;
                renderer.changeBrush(Get(unitCard.unitType));
            }
        }
    }
}

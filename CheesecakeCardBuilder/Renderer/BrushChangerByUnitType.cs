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
        private UnitCard card;

        public BrushChangerByUnitType(UnitCard card) {
            this.card = card;
        }

        public BrushChangerByUnitType(UnitCard card, Brush defaultBrush)
            : base(defaultBrush) {
            this.card = card;
        }

        public void update(TextRenderer renderer) {
            renderer.changeBrush(Get(card.unitType));
        }
    }
}

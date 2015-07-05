using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer {
    using CardParts;
    using System.Drawing;
    using CheesecakeCardBuilder.Unit;

    public class BrushChangerByType : ByTypeHandler<Brush> {
        private UnitCard card;
        private TextRenderer renderer;

        public BrushChangerByType(UnitCard card, TextRenderer renderer) {
            this.card = card;
            this.renderer = renderer;
        }

        public BrushChangerByType(UnitCard card, TextRenderer renderer, Brush defaultBrush)
            : base(defaultBrush) {
            this.card = card;
            this.renderer = renderer;
        }

        public void update() {
            renderer.changeBrush(Get(card.unitType));
        }
    }
}

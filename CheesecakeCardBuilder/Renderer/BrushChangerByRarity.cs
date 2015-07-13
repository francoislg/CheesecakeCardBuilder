using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer {
    using CardParts;
    using System.Drawing;
    using CheesecakeCardBuilder.Unit;

    public class BrushChangerByRarity : BrushChangerByType {
        private Brush rareBrush;
        private Brush defaultBrush;
        private Card card;

        public BrushChangerByRarity(Card card, Brush defaultBrush, Brush rareBrush) {
            this.card = card;
            this.defaultBrush = defaultBrush;
            this.rareBrush = rareBrush;
        }

        public void update(TextRenderer renderer) {
            if (card.rare) {
                renderer.changeBrush(rareBrush);
            } else {
                renderer.changeBrush(defaultBrush);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts {
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using Unit;

    public class CardTextByTypeRenderer : CardTextRenderer {
        private UnitCard card;
        private SolidBrush solidBrush {
            get {
                return (SolidBrush)brush;
            }
            set {
                brush = value;
            }
        }

        public CardTextByTypeRenderer(UnitCard card) {
            this.card = card;
        }

        public override void draw(Graphics graphics, String text) {
            Color color;
            switch (card.type) {
                case UnitType.Standard:
                    color = Color.Black;
                    break;
                case UnitType.Advanced:
                    color = Color.Turquoise;
                    break;
                case UnitType.Expert:
                    color = Color.LightGreen;
                    break;
                case UnitType.Master:
                    color = Color.FromArgb(255, 154, 51, 254);
                    break;
                default:
                    throw new NotSupportedException();
            }
            solidBrush.Color = color;
            base.draw(graphics, text);
        }
    }
}

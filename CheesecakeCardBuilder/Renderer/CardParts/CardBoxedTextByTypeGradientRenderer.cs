using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts {
    using Text;
    using Unit;
    public class CardBoxedTextByTypeGradientRenderer : CardBoxedTextRenderer {
        private UnitCard card;
        public LinearGradientBrush linearBrush {
            get {
                return (LinearGradientBrush)brush;
            }
            set {
                brush = value;
            }
        }

        public CardBoxedTextByTypeGradientRenderer(UnitCard card) {
            this.card = card;
        }

        public override void draw(Graphics graphics, String text) {
            Color color;
            switch (card.type) {
                case UnitType.Standard:
                    color = Color.FromArgb(255, 180, 180, 180);
                    break;
                case UnitType.Advanced:
                    color = Color.Turquoise;
                    break;
                case UnitType.Expert:
                    color = Color.LightGreen;
                    break;
                case UnitType.Master:
                    color = Color.Red;
                    break;
                default:
                    throw new NotSupportedException();
            }
            linearBrush.InterpolationColors = FontService.getInterpolationGradientColors(color);
            base.draw(graphics, text);
        }
    }
}

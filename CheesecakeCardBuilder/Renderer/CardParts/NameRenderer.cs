
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts {
    using System;
    using System.Drawing;
    using Config;
    using Text;

    public class NameRenderer : CardPartRenderer {
        private static readonly Rectangle POSITION = new Rectangle(170, 330, 450, 200);
        private ProjectConfig config;
        private Card card;
        private TextRenderer renderer;
        private BrushChangerByType brushChanger;
        private string cardType = "INVALID";

        public NameRenderer(ProjectConfig config, Card card) {
            this.config = config;
            this.card = card;
            Font font = config.nameFont;
            Brush brush = FontService.getGradiantBrush(font, 14);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Far;
            this.renderer = new CardBoxedTextRenderer() { box = POSITION, format = format, font = font, brush =brush };
            this.renderer.addEffect(new OutlineBoxedTextRenderer(font, POSITION, format, new Pen(Color.Gray, 8f)));
            this.renderer.addEffect(new FuzzyBoxedTextRenderer(font, new Rectangle(POSITION.X + 2, POSITION.Y + 2, POSITION.Width, POSITION.Height), format));
            this.brushChanger = FontService.getDefaultGradientBrushChangerByType(font, card);
            if (card is UnitCard) {
                cardType = "Unit";
            }else if (card is StructureCard){
                cardType = "Structure";
            } else if (card is CasterCard) {
                cardType = "Caster";
            }
        }

        public void draw(Graphics graphics) {
            brushChanger.update(renderer);
            renderer.draw(graphics, cardType + " - " + card.name);
        }
    }
}

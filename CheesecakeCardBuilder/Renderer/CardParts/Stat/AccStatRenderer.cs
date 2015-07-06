
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using CheesecakeCardBuilder.Unit;
    using Text;

    public class AccStatRenderer : CardPartRenderer {
        private static readonly Point POSITION = new Point(715, 975);
        private static readonly Point ICONPOSITION = new Point(POSITION.X - 50, POSITION.Y - 135);
        private ProjectConfig config;
        private UnitCard card;
        private CardTextRenderer renderer;
        private ImageRenderer iconRenderer;
        private BrushChangerByUnitType brushChanger;

        public AccStatRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            Font font = config.statsFont;
            this.iconRenderer = new ImageRenderer(new Bitmap(config.iconAccFile), ICONPOSITION);
            this.renderer = new CardTextRenderer() { brush = FontService.getGradiantBrush(config.statsFont, 28), font = font, position = POSITION };
            this.renderer.addDefaultEffects();
            this.brushChanger = FontService.getDefaultGradientBrushChangerByType(font, card);
        }

        public void draw(Graphics graphics) {
            brushChanger.update(renderer);
            iconRenderer.draw(graphics);
            renderer.draw(graphics, card.acc);
        }
    }
}

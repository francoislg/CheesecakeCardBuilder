
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using CheesecakeCardBuilder.Unit;

    public class SpdStatRenderer : CardPartRenderer {
        private static readonly Point POSITION = new Point(715, 700);
        private static readonly Point ICONPOSITION = new Point(POSITION.X - 60 - 10, POSITION.Y - 135);
        private ProjectConfig config;
        private UnitCard card;
        private CardTextRenderer renderer;
        private ImageRenderer iconRenderer;
        private BrushChangerByType brushChanger;

        public SpdStatRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            Font font = config.statsFont;
            this.iconRenderer = new ImageRenderer(new Bitmap(config.iconSpdFile), ICONPOSITION);
            this.renderer = new CardTextRenderer() { brush = FontService.getGradiantBrush(config.statsFont, 0), font = font, position = POSITION };
            this.renderer.addDefaultEffects();
            this.brushChanger = FontService.getDefaultGradientBrushChangerByType(font, card, renderer);
        }

        public void draw(Graphics graphics) {
            brushChanger.update();
            iconRenderer.draw(graphics);
            renderer.draw(graphics, card.spd);
        }
    }
}

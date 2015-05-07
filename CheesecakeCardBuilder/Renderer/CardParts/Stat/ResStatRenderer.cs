
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using Unit;

    public class ResStatRenderer : CardPartRenderer {
        private static readonly Point POSITION = new Point(655, 95);
        private static readonly Point ICONPOSITION = new Point(604, 82);
        private ProjectConfig config;
        private UnitCard card;
        private CardTextRenderer renderer;
        private ImageRenderer iconRenderer;

        public ResStatRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            this.iconRenderer = new ImageRenderer(new Bitmap(config.iconResFile), ICONPOSITION);
            this.renderer = new CardTextRenderer() { brush = new SolidBrush(Color.Black), font = config.topStatsFont, position = POSITION };
            this.renderer.addDefaultEffects();
        }

        public void draw(Graphics graphics) {
            iconRenderer.draw(graphics);
            renderer.draw(graphics, card.res);
        }
    }
}

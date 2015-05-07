
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using Unit;

    public class HPStatRenderer : CardPartRenderer {
        private static readonly Point POSITION = new Point(125, 95);
        private static readonly Point ICONPOSITION = new Point(73, 76);
        private ProjectConfig config;
        private UnitCard card;
        private CardTextRenderer renderer;
        private ImageRenderer iconRenderer;

        public HPStatRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            this.iconRenderer = new ImageRenderer(new Bitmap(config.iconHPFile), ICONPOSITION);
            this.renderer = new CardTextRenderer() { brush = new SolidBrush(Color.FromArgb(255, 99, 255, 99)), font = config.statsFont, position = POSITION };
            this.renderer.addDefaultEffects();
        }

        public void draw(Graphics graphics) {
            iconRenderer.draw(graphics);
            renderer.draw(graphics, card.hp);
        }
    }
}

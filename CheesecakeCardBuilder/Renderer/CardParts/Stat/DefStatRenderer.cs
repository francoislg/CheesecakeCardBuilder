
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using Unit;

    public class DefStatRenderer : CardPartRenderer {
        private static readonly Point POSITION = new Point(70, 975);
        private static readonly Point ICONPOSITION = new Point(POSITION.X - 50, POSITION.Y - 135);
        private ProjectConfig config;
        private UnitCard card;
        private CardTextRenderer renderer;
        private ImageRenderer iconRenderer;

        public DefStatRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            this.iconRenderer = new ImageRenderer(new Bitmap(config.iconDefFile), ICONPOSITION);
            this.renderer = new CardTextRenderer() { brush = FontService.getGradiantBrush(config.statsFont, 10), font = config.statsFont, position = POSITION };
            this.renderer.addDefaultEffects();
        }

        public void draw(Graphics graphics) {
            iconRenderer.draw(graphics);
            renderer.draw(graphics, card.def);
        }
    }
}

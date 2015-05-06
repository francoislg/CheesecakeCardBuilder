
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using Unit;

    public class SpdStatRenderer : CardPartRenderer {
        private static readonly Point DEFAULTPOSITION = new Point(715, 670);
        private ProjectConfig config;
        private UnitCard card;
        private CardTextRenderer renderer;

        public SpdStatRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            this.renderer = new CardTextRenderer() { brush = FontService.getGradiantBrush(config.statsFont, 0), font = config.statsFont, position = DEFAULTPOSITION };
        }

        public void draw(Graphics graphics) {
            renderer.draw(graphics, card.spd);
        }
    }
}

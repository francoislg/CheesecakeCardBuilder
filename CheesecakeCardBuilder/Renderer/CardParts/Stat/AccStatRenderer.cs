
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using Unit;
    using Text;

    public class AccStatRenderer : CardPartRenderer {
        private static readonly Point DEFAULTPOSITION = new Point(715, 960);
        private ProjectConfig config;
        private UnitCard card;
        private CardTextRenderer renderer;

        public AccStatRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            this.renderer = new CardTextRenderer() { brush = FontService.getGradiantBrush(config.statsFont, 13), font = config.statsFont, position = DEFAULTPOSITION };
            this.renderer.addDefaultEffects();
        }

        public void draw(Graphics graphics) {
            renderer.draw(graphics, card.acc);
        }
    }
}

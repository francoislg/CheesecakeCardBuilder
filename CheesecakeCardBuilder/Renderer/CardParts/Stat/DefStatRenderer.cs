
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
        private static readonly Point DEFAULTPOSITION = new Point(70, 960);
        private ProjectConfig config;
        private UnitCard card;
        private CardTextRenderer renderer;

        public DefStatRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            this.renderer = new CardTextRenderer() { brush = FontService.getGradiantBrush(config.statsFont, 13), font = config.statsFont, position = DEFAULTPOSITION };
        }

        public void draw(Graphics graphics) {
            renderer.draw(graphics, card.def);
        }
    }
}

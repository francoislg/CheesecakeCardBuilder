
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
        private static readonly Point DEFAULTPOSITION = new Point(125, 95);
        private ProjectConfig config;
        private UnitCard card;
        private CardTextRenderer renderer;

        public HPStatRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            this.renderer = new CardTextRenderer() { brush = new SolidBrush(Color.Green), font = config.statsFont, position = DEFAULTPOSITION };
        }

        public void draw(Graphics graphics) {
            renderer.draw(graphics, card.hp);
        }
    }
}

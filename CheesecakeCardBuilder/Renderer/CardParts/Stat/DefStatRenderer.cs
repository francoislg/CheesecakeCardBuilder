
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using CheesecakeCardBuilder.Unit;

    public class DefStatRenderer : CardPartRenderer {
        private ProjectConfig config;
        private UnitCard card;
        private IconTextRenderer iconTextRenderer;

        public DefStatRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            this.iconTextRenderer = new IconTextRenderer(CardPosition.BottomLeft, card, config.statsFont, config.iconDefFile);
            this.iconTextRenderer.renderer.addDefaultEffects();
        }

        public void draw(Graphics graphics) {
            this.iconTextRenderer.draw(graphics, card.def);
        }
    }
}


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Gear {
    using System;
    using System.Drawing;
    using Config;
    using Text;
    using CheesecakeCardBuilder.Renderer.CardParts.Stat;

    public class GearDefStatRenderer : CardPartRenderer {
        private ProjectConfig config;
        private GearCard card;
        private IconTextRenderer iconTextRenderer;

        public GearDefStatRenderer(ProjectConfig config, GearCard card) {
            this.config = config;
            this.card = card;
            this.iconTextRenderer = new IconTextRenderer(CardPosition.TopRight, card, config.statsFont, config.iconDefFile);
            this.iconTextRenderer.renderer.addDefaultEffects();
        }

        public void draw(Graphics graphics) {
            this.iconTextRenderer.draw(graphics, card.def);
        }
    }
}

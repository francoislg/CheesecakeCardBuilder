
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

    public class GearAtkStatRenderer : CardPartRenderer {
        private ProjectConfig config;
        private GearCard card;
        private IconTextRenderer iconTextRenderer;

        public GearAtkStatRenderer(ProjectConfig config, GearCard card) {
            this.config = config;
            this.card = card;
            this.iconTextRenderer = new IconTextRenderer(CardPosition.TopLeft, card, config.statsFont, config.iconAtkFile);
            this.iconTextRenderer.renderer.addDefaultEffects();
        }

        public void draw(Graphics graphics) {
            this.iconTextRenderer.draw(graphics, card.atk);
        }
    }
}

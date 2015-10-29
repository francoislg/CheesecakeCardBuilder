
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Location {
    using System;
    using System.Drawing;
    using Config;
    using CheesecakeCardBuilder.Unit;
    using Text;
    using CheesecakeCardBuilder.Renderer.CardParts.Stat;

    public class LifespanStatRenderer : CardPartRenderer {
        private ProjectConfig config;
        private LocationCard card;
        private IconTextRenderer iconTextRenderer;

        public LifespanStatRenderer(ProjectConfig config, LocationCard card) {
            this.config = config;
            this.card = card;
            this.iconTextRenderer = new IconTextRenderer(CardPosition.TopRight, card, config.statsFont, config.iconLifespanFile);
            this.iconTextRenderer.renderer.addDefaultEffects();
        }

        public void draw(Graphics graphics) {
            this.iconTextRenderer.draw(graphics, card.lifespan);
        }
    }
}


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using CheesecakeCardBuilder.Unit;
    using System.Drawing.Drawing2D;

    public class AtkStatRenderer : CardPartRenderer {
        private ProjectConfig config;
        private UnitCard card;
        private IconTextRenderer iconTextRenderer;

        public AtkStatRenderer(ProjectConfig config, UnitCard card) {
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

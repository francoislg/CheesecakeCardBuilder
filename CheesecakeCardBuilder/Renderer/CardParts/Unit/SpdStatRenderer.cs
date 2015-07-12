
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using CheesecakeCardBuilder.Unit;

    public class SpdStatRenderer : CardPartRenderer {
        private ProjectConfig config;
        private UnitCard card;
        private IconTextRenderer renderer;

        public SpdStatRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            this.renderer = new IconTextRenderer(CardPosition.TopRight, card, config.statsFont, config.iconSpdFile);
            this.renderer.renderer.addDefaultEffects();
        }

        public void draw(Graphics graphics) {
            renderer.draw(graphics, card.spd);
        }
    }
}

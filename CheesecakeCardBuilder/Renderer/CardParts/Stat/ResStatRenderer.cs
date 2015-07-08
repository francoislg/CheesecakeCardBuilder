
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using CheesecakeCardBuilder.Unit;

    public class ResStatRenderer : CardPartRenderer {
        private static readonly Point POSITION = new Point(655, 95);
        private static readonly Point ICONPOSITION = new Point(604, 82);
        private ProjectConfig config;
        private Card card;
        private IconTextRenderer renderer;

        public ResStatRenderer(ProjectConfig config, Card card, string iconFile) {
            this.config = config;
            this.card = card;
            this.renderer = new IconTextRenderer(CardPosition.Resources, card, config.topStatsFont, iconFile);
            this.renderer.renderer.addDefaultEffects();
        }

        public void draw(Graphics graphics) {
            renderer.draw(graphics, card.res);
        }
    }
}

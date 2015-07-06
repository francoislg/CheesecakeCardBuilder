using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Structure {
    using CheesecakeCardBuilder.Config;
    using CheesecakeCardBuilder.Renderer.CardParts.Stat;
    using CheesecakeCardBuilder.Structure;
    using System.Drawing;

    public class ProductionCardPartRenderer : CardPartRenderer {
        private ProjectConfig config;
        private StructureCard card;
        private IconTextRenderer renderer;

        public ProductionCardPartRenderer(ProjectConfig config, StructureCard card) {
            this.config = config;
            this.card = card;
            this.renderer = new IconTextRenderer(CardPosition.TopLeft, card, config.statsFont, config.iconProdFile);
            this.renderer.renderer.addDefaultEffects();
        }

        public void draw(Graphics graphics) {
            renderer.draw(graphics, card.prod);
        }
    }
}

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

    public class StorageCardPartRenderer : CardPartRenderer {
        private ProjectConfig config;
        private StructureCard card;
        private IconTextRenderer storageRenderer;
        private IconTextRenderer storageSpeedRenderer;

        public StorageCardPartRenderer(ProjectConfig config, StructureCard card) {
            this.config = config;
            this.card = card;
            this.storageRenderer = new IconTextRenderer(CardPosition.TopLeft, card, config.statsFont, config.iconStorageFile);
            this.storageRenderer.renderer.addDefaultEffects();
            this.storageSpeedRenderer = new IconTextRenderer(CardPosition.BottomLeft, card, config.statsFont, config.iconStorageSpeedFile);
            this.storageSpeedRenderer.renderer.addDefaultEffects();
        }

        public void draw(Graphics graphics) {
            storageRenderer.draw(graphics, card.storage);
            storageSpeedRenderer.draw(graphics, card.storSpeed);
        }
    }
}

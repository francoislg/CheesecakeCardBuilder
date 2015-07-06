
namespace CheesecakeCardBuilder.Renderer.CardParts {
    using Unit;
    using Config;
    using System;
    using CardParts;
    using CardParts.Stat;

    public enum PartType {
        Name, Description
    }

    public abstract class CardPartRendererFactory {
        protected ProjectConfig config;
        protected Card card;

        public CardPartRendererFactory(ProjectConfig config, Card card) {
            this.config = config;
            this.card = card;
        }

        public CardPartRenderer create(PartType type) {
            switch (type) {
                case PartType.Name:
                    return new NameRenderer(config, card);
                case PartType.Description:
                    return new DescriptionsRenderer(config, card);
                default:
                    throw new NotSupportedException();
            }
        }

        
    }
}

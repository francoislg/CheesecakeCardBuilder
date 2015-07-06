
namespace CheesecakeCardBuilder.Renderer.CardParts {
    using CheesecakeCardBuilder.Structure;
    using Config;
    using System;
    using CardParts;
    using CardParts.Stat;
    using Renderer.CardParts.Structure;

    public enum StructurePartType {
        Stats
    }

    public class StructureCardPartRendererFactory : CardPartRendererFactory {
        private StructureCard structureCard;

        public StructureCardPartRendererFactory(ProjectConfig config, StructureCard structureCard)
            : base(config, structureCard) {
                this.structureCard = structureCard;
        }

        public CardPartRenderer create(StructurePartType type) {
            switch (type) {
                case StructurePartType.Stats:
                    return new StructureStatRendererByType(config, structureCard);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}

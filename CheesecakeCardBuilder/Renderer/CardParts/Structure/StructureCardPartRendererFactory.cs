
namespace CheesecakeCardBuilder.Renderer.CardParts.Structure {
    using CheesecakeCardBuilder.Structure;
    using Config;
    using System;
    using CardParts;
    using CardParts.Stat;
    using Renderer.CardParts.Structure;

    public enum StructurePartType {
        Stats, Res
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
                case StructurePartType.Res:
                    return new ResStatRenderer(config, structureCard, config.iconGreenResFile);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}

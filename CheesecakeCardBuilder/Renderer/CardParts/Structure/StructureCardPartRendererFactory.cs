
namespace CheesecakeCardBuilder.Renderer.CardParts {
    using Structure;
    using Config;
    using System;
    using CardParts;
    using CardParts.Stat;

    public enum StructurePartType {
        
    }

    public class StructureCardPartRendererFactory : CardPartRendererFactory {
        private StructureCard structureCard;

        public StructureCardPartRendererFactory(ProjectConfig config, StructureCard structureCard)
            : base(config, structureCard) {
                this.structureCard = structureCard;
        }

        public CardPartRenderer create(StructurePartType type) {
            switch (type) {
                default:
                    throw new NotSupportedException();
            }
        }
    }
}

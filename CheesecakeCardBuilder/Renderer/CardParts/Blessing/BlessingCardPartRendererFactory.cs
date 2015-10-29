
namespace CheesecakeCardBuilder.Renderer.CardParts.Blessing {
    using Config;
    using System;
    using CardParts;
    using CardParts.Stat;

    public enum BlessingPartType {
        Res
    }

    public class BlessingCardPartRendererFactory : CardPartRendererFactory {
        private BlessingCard blessingCard;

        public BlessingCardPartRendererFactory(ProjectConfig config, BlessingCard blessingCard)
            : base(config, blessingCard) {
                this.blessingCard = blessingCard;
        }

        public CardPartRenderer create(BlessingPartType type) {
            switch (type) {
                case BlessingPartType.Res:
                    return new ResStatRenderer(config, blessingCard, config.iconResBlessFile);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}

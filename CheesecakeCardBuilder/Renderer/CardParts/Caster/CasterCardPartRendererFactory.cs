
namespace CheesecakeCardBuilder.Renderer.CardParts.Caster {
    using Config;
    using System;
    using CardParts;
    using CardParts.Stat;
    using Renderer.CardParts.Caster;

    public enum CasterPartType {
        Res
    }

    public class CasterCardPartRendererFactory : CardPartRendererFactory {
        private CasterCard casterCard;

        public CasterCardPartRendererFactory(ProjectConfig config, CasterCard casterCard)
            : base(config, casterCard) {
                this.casterCard = casterCard;
        }

        public CardPartRenderer create(CasterPartType type) {
            switch (type) {
                case CasterPartType.Res:
                    return new ResStatRenderer(config, casterCard, config.iconRes2File);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}

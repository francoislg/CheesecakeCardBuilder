
namespace CheesecakeCardBuilder.Renderer.CardParts.Gear {
    using Config;
    using System;
    using CardParts;
    using CardParts.Stat;

    public enum GearPartType {
        Res, Atk, Def
    }

    public class GearCardPartRendererFactory : CardPartRendererFactory {
        private GearCard gearCard;

        public GearCardPartRendererFactory(ProjectConfig config, GearCard gearCard)
            : base(config, gearCard) {
                this.gearCard = gearCard;
        }

        public CardPartRenderer create(GearPartType type) {
            switch (type) {
                case GearPartType.Atk:
                    return new GearAtkStatRenderer(config, gearCard);
                case GearPartType.Def:
                    return new GearDefStatRenderer(config, gearCard);
                case GearPartType.Res:
                    return new ResStatRenderer(config, gearCard, config.iconResFile);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}

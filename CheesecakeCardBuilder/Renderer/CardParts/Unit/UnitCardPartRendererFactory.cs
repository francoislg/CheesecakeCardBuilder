
namespace CheesecakeCardBuilder.Renderer.CardParts {
    using Unit;
    using Config;
    using System;
    using CardParts;
    using CardParts.Stat;

    public enum UnitPartType {
        Atk, Def, Spd, Acc, Hp, Res, Type, Background
    }

    public class UnitCardPartRendererFactory : CardPartRendererFactory {
        private UnitCard unitCard;

        public UnitCardPartRendererFactory(ProjectConfig config, UnitCard unitCard) : base(config, unitCard) {
            this.unitCard = unitCard;
        }

        public CardPartRenderer create(UnitPartType type) {
            switch (type) {
                case UnitPartType.Atk:
                    return new AtkStatRenderer(config, unitCard);
                case UnitPartType.Def:
                    return new DefStatRenderer(config, unitCard);
                case UnitPartType.Spd:
                    return new SpdStatRenderer(config, unitCard);
                case UnitPartType.Acc:
                    return new AccStatRenderer(config, unitCard);
                case UnitPartType.Hp:
                    return new HPStatRenderer(config, unitCard);
                case UnitPartType.Res:
                    return new UnitResStatRenderer(config, unitCard);
                case UnitPartType.Type:
                    return new UnitTypeRenderer(config, unitCard);
                case UnitPartType.Background:
                    return new UnitBackgroundRenderer(config, unitCard);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}

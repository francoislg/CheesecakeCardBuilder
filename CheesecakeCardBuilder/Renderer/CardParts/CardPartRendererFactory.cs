
namespace CheesecakeCardBuilder.Renderer.CardParts {
    using Unit;
    using Config;
    using System;
    using CardParts;
    using CardParts.Stat;

    public enum PartType {
        Atk, Def, Spd, Acc, Hp, Res, Name, Description
    }

    public class CardPartRendererFactory {
        private ProjectConfig config;
        private UnitCard unitCard;

        public CardPartRendererFactory(ProjectConfig config, UnitCard unitCard){
            this.config = config;
            this.unitCard = unitCard;
        }

        public CardPartRenderer create(PartType type) {
            switch (type) {
                case PartType.Atk:
                    return new AtkStatRenderer(config, unitCard);
                case PartType.Def:
                    return new DefStatRenderer(config, unitCard);
                case PartType.Spd:
                    return new SpdStatRenderer(config, unitCard);
                case PartType.Acc:
                    return new AccStatRenderer(config, unitCard);
                case PartType.Hp:
                    return new HPStatRenderer(config, unitCard);
                case PartType.Res:
                    return new ResStatRenderer(config, unitCard);
                case PartType.Name:
                    return new NameRenderer(config, unitCard);
                case PartType.Description:
                    return new DescriptionsRenderer(config, unitCard);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}

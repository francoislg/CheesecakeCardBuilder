
namespace CheesecakeCardBuilder.Renderer.CardParts {
    using Unit;
    using Config;
    using System;

    public enum StatTypes {
        Atk, Def, Spd, Acc, Hp, Res, Name, Description
    }

    public class StatRendererFactory {
        private ProjectConfig config;
        private UnitCard unitCard;

        public StatRendererFactory(ProjectConfig config, UnitCard unitCard){
            this.config = config;
            this.unitCard = unitCard;
        }

        public CardPartRenderer create(StatTypes type) {
            switch (type) {
                case StatTypes.Atk:
                    return new AtkStatRenderer(config, unitCard);
                case StatTypes.Def:
                    return new DefStatRenderer(config, unitCard);
                case StatTypes.Spd:
                    return new SpdStatRenderer(config, unitCard);
                case StatTypes.Acc:
                    return new AccStatRenderer(config, unitCard);
                case StatTypes.Hp:
                    return new HPStatRenderer(config, unitCard);
                case StatTypes.Res:
                    return new ResStatRenderer(config, unitCard);
                case StatTypes.Name:
                    return new NameRenderer(config, unitCard);
                case StatTypes.Description:
                    return new DescriptionsRenderer(config, unitCard);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}

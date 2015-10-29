
namespace CheesecakeCardBuilder.Renderer.CardParts.Location {
    using Config;
    using System;
    using CardParts;
    using CardParts.Stat;

    public enum LocationPartType {
        ProductionSpeed, Lifespan
    }

    public class LocationCardPartRendererFactory : CardPartRendererFactory {
        private LocationCard locationCard;

        public LocationCardPartRendererFactory(ProjectConfig config, LocationCard locationCard)
            : base(config, locationCard) {
                this.locationCard = locationCard;
        }

        public CardPartRenderer create(LocationPartType type) {
            switch (type) {
                case LocationPartType.ProductionSpeed:
                    return new ProductionSpeedStatRenderer(config, locationCard);
                case LocationPartType.Lifespan:
                    return new LifespanStatRenderer(config, locationCard);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}

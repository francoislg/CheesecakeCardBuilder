using CheesecakeCardBuilder.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Builders {
    using Unit;
    using CheesecakeCardBuilder.Structure;
    using CheesecakeCardBuilder.Unit;
    using CheesecakeCardBuilder.Renderer;
    using CheesecakeCardBuilder.Builders.Structure;
    using CheesecakeCardBuilder.Builders.Caster;
    public class CardBuilderConfig {
        private ProjectConfig config;
        private CardUpdater updater;
        public CardBuilderConfig(ProjectConfig config, CardUpdater updater) {
            this.config = config;
            this.updater = updater;
        }

        public CardRenderer getRenderer(Card card) {
            if (card is UnitCard) {
                return new UnitCardRenderer((UnitCard)card, config);
            } else if(card is StructureCard) {
                return new StructureCardRenderer((StructureCard)card, config);
            } else if (card is CasterCard) {
                return new CasterCardRenderer((CasterCard)card, config);
            } else {
                throw new NotSupportedException();
            }
        }

        public CardControl getControl(Card card){
            if (card is UnitCard) {
                return new UnitCardControl(config, updater);
            } else if(card is StructureCard) {
                return new StructureCardControl(config, updater);
            }else if(card is CasterCard){
                return new CasterCardControl(config, updater);
            }else{
                throw new NotSupportedException();
            }
        }
    }
}

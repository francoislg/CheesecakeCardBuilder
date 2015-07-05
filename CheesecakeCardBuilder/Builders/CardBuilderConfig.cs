using CheesecakeCardBuilder.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Builder {
    using Unit;
    using CheesecakeCardBuilder.Unit;
    using CheesecakeCardBuilder.Renderer;
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
            } else {
                throw new NotSupportedException();
            }
        }

        public CardControl getControl(Card card){
            if (card is UnitCard) {
                return new UnitCardControl(config, (UnitCard)card, updater);
            } else {
                throw new NotSupportedException();
            }
        }
    }
}


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using Unit;

    public class ResStatRenderer : StatRenderer {
        private static readonly Point DEFAULTPOSITION = new Point(655, 95);
        private UnitCard card;

        public ResStatRenderer(ProjectConfig config, UnitCard card)
            : base(config, DEFAULTPOSITION) {
            this.card = card;
            this.font = config.topStatsFont;
            this.brush = FontService.getGradiantBrush(font, 0);
        }

        protected override void update(Graphics graphics) {
            this.toDraw = card.res;
        }
    }
}

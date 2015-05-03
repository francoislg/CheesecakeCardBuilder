
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts {
    using System;
    using System.Drawing;
    using Config;
    using Unit;

    public class AccStatRenderer : DefaultStatRenderer {
        private static readonly Point DEFAULTPOSITION = new Point(715, 960);
        private UnitCard card;

        public AccStatRenderer(ProjectConfig config, UnitCard card)
            : base(config, DEFAULTPOSITION) {
            this.card = card;
            this.font = new Font(config.statsFont, config.statsFontSize, FontStyle.Regular);
            this.brush = FontService.getGradiantBrush(font, 30);
        }

        protected override void update(Graphics graphics) {
            this.toDraw = card.acc;
        }
    }
}

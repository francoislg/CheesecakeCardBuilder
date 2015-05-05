
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using Unit;

    public class DefStatRenderer : StatRenderer {
        private static readonly Point DEFAULTPOSITION = new Point(70, 960);
        private UnitCard card;

        public DefStatRenderer(ProjectConfig config, UnitCard card)
            : base(config, DEFAULTPOSITION) {
            this.card = card;
            this.font = config.statsFont;
            this.brush = FontService.getGradiantBrush(font, 13);
        }

        protected override void update(Graphics graphics) {
            this.toDraw = card.def;
        }
    }
}

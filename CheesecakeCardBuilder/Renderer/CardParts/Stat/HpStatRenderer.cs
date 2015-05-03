
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using Unit;

    public class HPStatRenderer : StatRenderer {
        private static readonly Point DEFAULTPOSITION = new Point(125, 95);
        private UnitCard card;

        public HPStatRenderer(ProjectConfig config, UnitCard card)
            : base(config, DEFAULTPOSITION) {
            this.card = card;
            this.font = new Font(config.topStatsFont, config.topStatsFontSize, FontStyle.Regular);
            this.brush = new SolidBrush(Color.Green);
        }

        protected override void update(Graphics graphics) {
            this.toDraw = card.hp;
        }
    }
}

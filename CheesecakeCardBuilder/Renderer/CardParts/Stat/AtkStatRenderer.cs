
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using Unit;

    public class AtkStatRenderer : StatRenderer {
        private static readonly Point DEFAULTPOSITION = new Point(70, 670);
        private UnitCard card;
        private Image icon;

        public AtkStatRenderer(ProjectConfig config, UnitCard card)
            : base(config, DEFAULTPOSITION) {
            this.card = card;
            this.font = config.statsFont;
            this.brush = FontService.getGradiantBrush(font, 0);
            this.icon = new Bitmap(config.iconAtkPath);
        }

        protected override void update(Graphics graphics) {
            this.toDraw = card.atk;
        }

        public override void draw(Graphics graphics) {
            base.draw(graphics);
            graphics.DrawImage(icon, DEFAULTPOSITION);
        }
    }
}

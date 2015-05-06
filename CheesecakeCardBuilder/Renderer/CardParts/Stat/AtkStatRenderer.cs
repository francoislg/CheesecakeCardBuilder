
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using Unit;
    using System.Drawing.Drawing2D;

    public class AtkStatRenderer : CardPartRenderer {
        private static readonly Point DEFAULTPOSITION = new Point(70, 750);
        private ProjectConfig config;
        private UnitCard card;
        private CardTextRenderer renderer;
        private Image icon;

        public AtkStatRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            this.icon = new Bitmap(config.iconAtkPath);
            this.renderer = new CardTextRenderer() { brush = FontService.getGradiantBrush(config.statsFont, 13), font = config.statsFont, position = DEFAULTPOSITION };
        }

        public void draw(Graphics graphics) {
            renderer.draw(graphics, card.atk);
            graphics.DrawImage(icon, DEFAULTPOSITION.X - 60, DEFAULTPOSITION.Y - 150, icon.Size.Width, icon.Size.Height);
        }
    }
}

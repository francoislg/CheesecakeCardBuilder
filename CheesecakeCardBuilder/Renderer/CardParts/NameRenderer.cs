
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts {
    using System;
    using System.Drawing;
    using Config;
    using Unit;

    public class NameRenderer : CardPartRenderer {
        private static readonly Rectangle DEFAULTPOSITION = new Rectangle(170, 360, 450, 200);
        private ProjectConfig config;
        private UnitCard card;
        private Font font;
        private Brush brush;
        private StringFormat format;

        public NameRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            this.font = config.nameFont;
            this.brush = FontService.getDefaultBrush();
            this.format = new StringFormat();
            this.format.Alignment = StringAlignment.Center;
            this.format.LineAlignment = StringAlignment.Far;
        }

        public void draw(Graphics graphics) {
            graphics.DrawString(card.name, font, brush, DEFAULTPOSITION, format);
        }
    }
}

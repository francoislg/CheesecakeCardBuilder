using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    public class IconRenderer {
        private Image icon;
        private Point position;

        public IconRenderer(Image icon, Point position) {
            this.icon = icon;
            this.position = position;
        }

        public void draw(Graphics graphics) {
            graphics.DrawImage(icon, position.X, position.Y, icon.Width, icon.Height);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.Text {
    public class FuzzyTextRenderer : TextEffectRenderer {
        private FuzzyRenderer renderer;
        private Font font;
        private Point position;
        private StringFormat format;

        public FuzzyTextRenderer(Font font, Point position, StringFormat format) {
            this.font = font;
            this.position = position;
            this.format = format;
            this.renderer = new FuzzyRenderer(Color.Black, 200, 20, 2);
        }

        public void draw(Graphics graphics, String text) {
            if (!String.IsNullOrEmpty(text)) {
                GraphicsPath graphicsPath = new GraphicsPath();
                graphicsPath.AddString(text, font.FontFamily, 0, graphics.DpiY * font.SizeInPoints / 72, position, format);
                renderer.draw(graphics, graphicsPath);
                graphicsPath.Dispose();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.Text {
    public class FuzzyBoxedTextRenderer : TextEffectRenderer {
        private FuzzyRenderer renderer;
        private Font font;
        private Rectangle box;
        private StringFormat format;

        public FuzzyBoxedTextRenderer(Font font, Rectangle box, StringFormat format) {
            this.font = font;
            this.box = box;
            this.format = format;
            this.renderer = new FuzzyRenderer(Color.Black, 150, 10, 1);
        }

        public void draw(Graphics graphics, String text) {
            if (!String.IsNullOrEmpty(text)) {
                GraphicsPath graphicsPath = new GraphicsPath();
                graphicsPath.AddString(text, font.FontFamily, 0, graphics.DpiY * font.SizeInPoints / 72, box, format);
                renderer.draw(graphics, graphicsPath);
                graphicsPath.Dispose();
            }
        }
    }
}

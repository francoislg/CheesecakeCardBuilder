using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.Text {
    public class OutlineTextRenderer : TextEffectRenderer {
        private Font font;
        private Point position;
        private StringFormat format;
        private Pen outlinePen;

        public OutlineTextRenderer(Font font, Point position, StringFormat format, Pen outlinePen) {
            this.font = font;
            this.position = position;
            this.format = format;
            this.outlinePen = outlinePen;
        }

        public void draw(Graphics graphics, String text) {
            if (!String.IsNullOrEmpty(text)) {
                GraphicsPath graphicsPath = new GraphicsPath();
                graphicsPath.AddString(text, font.FontFamily, 0, graphics.DpiY * font.SizeInPoints / 72, position, format);
                graphics.DrawPath(outlinePen, graphicsPath);
                graphicsPath.Dispose();
            }
        }
    }
}

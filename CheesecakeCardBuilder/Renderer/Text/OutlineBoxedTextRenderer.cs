using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.Text {
    public class OutlineBoxedTextRenderer : TextEffectRenderer {
        private Font font;
        private Rectangle box;
        private StringFormat format;
        private Pen outlinePen;

        public OutlineBoxedTextRenderer(Font font, Rectangle position, StringFormat format, Pen outlinePen) {
            this.font = font;
            this.box = position;
            this.format = format;
            this.outlinePen = outlinePen;
            this.outlinePen.LineJoin = LineJoin.Round;
            this.outlinePen.EndCap = LineCap.Round;
            this.outlinePen.StartCap = LineCap.Round;
        }

        public void draw(Graphics graphics, String text) {
            if (!String.IsNullOrEmpty(text)) {
                GraphicsPath graphicsPath = new GraphicsPath();
                graphicsPath.AddString(text, font.FontFamily, 0, graphics.DpiY * font.SizeInPoints / 72, box, format);
                graphics.DrawPath(outlinePen, graphicsPath);
                graphicsPath.Dispose();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer {
    // THANKS http://csharphelper.com/blog/2011/10/draw-fuzzy-lines-to-make-shadows-in-c/

    public class FuzzyRenderer {
        private Color color;
        private int maxOpacity;
        private int width;
        private int opaqueWidth;
        private int num_steps;
        private float delta;

        public FuzzyRenderer(Color color, int maxOpacity, int width, int opaqueWidth) {
            this.color = color;
            this.maxOpacity = maxOpacity;
            this.width = width;
            this.opaqueWidth = opaqueWidth;
            update();
        }

        private void update(){
            num_steps = width - opaqueWidth + 1;
            delta = (float)maxOpacity / num_steps / num_steps;
        }

        public void draw(Graphics graphics, GraphicsPath graphicsPath) {
            float alpha = delta;
            for (int thickness = width; thickness >= opaqueWidth; thickness--) {
                Color colorWithAlpha = Color.FromArgb((int)alpha, color);
                using (Pen pen = new Pen(colorWithAlpha, thickness)) {
                    pen.EndCap = LineCap.Round;
                    pen.StartCap = LineCap.Round;
                    graphics.DrawPath(pen, graphicsPath);
                }
                alpha += delta;
            }
        }
    }
}

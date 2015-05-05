
namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Renderer.CardParts;
    using Config;
    using System.Drawing.Drawing2D;

    public abstract class StatRenderer : CardPartRenderer, IDisposable {
        protected ProjectConfig config;
        protected Point position;
        protected Nullable<Rectangle> rectangle = null;
        protected Brush brush = FontService.getDefaultBrush();
        protected StringFormat format = FontService.getDefaultFormat();
        protected Font font = FontService.getDefaultFont();
        protected String toDraw;
        protected Pen outlinePen = new Pen(Color.Gray, 2.5f);

        public StatRenderer(ProjectConfig config, Point position) {
            this.config = config;
            this.position = position;
            this.toDraw = "0";
        }

        public StatRenderer(ProjectConfig config, Rectangle rectangle) : this(config, rectangle.Location) {
            this.rectangle = rectangle;
        }

        protected abstract void update(Graphics graphics);

        public virtual void draw(Graphics graphics) {
            update(graphics);
            if (rectangle.HasValue) {
                drawShadow(graphics, rectangle.Value.Location);
                drawOutline(graphics, rectangle.Value.Location);
                graphics.DrawString(toDraw, font, brush, rectangle.Value, format);
            } else {
                drawShadow(graphics, position);
                drawOutline(graphics, position);
                graphics.DrawString(toDraw, font, brush, position, format);
            }
        }

        private void drawOutline(Graphics graphics, Point position) {
            if (!String.IsNullOrEmpty(toDraw)) {
                GraphicsPath p = new GraphicsPath();
                p.AddString(toDraw, font.FontFamily, 0, graphics.DpiY * font.SizeInPoints / 72, position, format);
                graphics.DrawPath(outlinePen, p);
                p.Dispose();
            }
        }

        private void drawShadow(Graphics graphics, Point originalPosition) {
            if (!String.IsNullOrEmpty(toDraw)) {
                GraphicsPath p = new GraphicsPath();
                p.AddString(toDraw, font.FontFamily, 0, graphics.DpiY * font.SizeInPoints / 72, new Point(position.X + 2, position.Y + 2), format);
                DrawPathWithFuzzyLine(p, graphics, Color.Black, 200, 20, 2);
                p.Dispose();
            }
        }

        // THANKS http://csharphelper.com/blog/2011/10/draw-fuzzy-lines-to-make-shadows-in-c/
        private void DrawPathWithFuzzyLine(GraphicsPath path, Graphics gr, Color base_color, int max_opacity, int width, int opaque_width) {
            int num_steps = width - opaque_width + 1;
            float delta = (float)max_opacity / num_steps / num_steps;
            float alpha = delta;
            for (int thickness = width; thickness >= opaque_width; thickness--) {
                Color color = Color.FromArgb(
                (int)alpha,
                base_color.R,
                base_color.G,
                base_color.B);
                using (Pen pen = new Pen(color, thickness)) {
                    pen.EndCap = LineCap.Round;
                    pen.StartCap = LineCap.Round;
                    gr.DrawPath(pen, path);
                }
                alpha += delta;
            }
        }

        public void Dispose() {
            brush.Dispose();
            format.Dispose();
        }
    }
}

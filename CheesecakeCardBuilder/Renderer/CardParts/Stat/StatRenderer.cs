
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
                drawOutline(graphics, rectangle.Value.Location);
                graphics.DrawString(toDraw, font, brush, rectangle.Value, format);
            } else {
                drawOutline(graphics, position);
                graphics.DrawString(toDraw, font, brush, position, format);
            }
        }

        private void drawOutline(Graphics graphics, Point position) {
            GraphicsPath p = new GraphicsPath();
            if (toDraw != null) {
                p.AddString(toDraw, font.FontFamily, 0, graphics.DpiY * font.SizeInPoints / 72, position, format);
                graphics.DrawPath(new Pen(Color.Gray, 2.5f), p);
            }
        }

        public void Dispose() {
            brush.Dispose();
            format.Dispose();
        }
    }
}

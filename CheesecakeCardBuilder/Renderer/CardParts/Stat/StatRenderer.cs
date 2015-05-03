
namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Renderer.CardParts;
    using Config;

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
                graphics.DrawString(toDraw, font, brush, rectangle.Value, format);
            } else {
                graphics.DrawString(toDraw, font, brush, position, format);
            }
        }

        public void Dispose() {
            brush.Dispose();
            format.Dispose();
            font.Dispose();
        }
    }
}


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
        protected FuzzyRenderer fuzzyRenderer;

        public StatRenderer(ProjectConfig config, Point position) {
            this.config = config;
            this.position = position;
            this.toDraw = "0";
            this.fuzzyRenderer = new FuzzyRenderer(Color.Black, 200, 20, 2);
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
                GraphicsPath graphicsPath = new GraphicsPath();
                graphicsPath.AddString(toDraw, font.FontFamily, 0, graphics.DpiY * font.SizeInPoints / 72, position, format);
                graphics.DrawPath(outlinePen, graphicsPath);
                graphicsPath.Dispose();
            }
        }

        private void drawShadow(Graphics graphics, Point originalPosition) {
            if (!String.IsNullOrEmpty(toDraw)) {
                GraphicsPath graphicsPath = new GraphicsPath();
                graphicsPath.AddString(toDraw, font.FontFamily, 0, graphics.DpiY * font.SizeInPoints / 72, new Point(position.X + 2, position.Y + 2), format);
                fuzzyRenderer.draw(graphics, graphicsPath);
                graphicsPath.Dispose();
            }
        }

        public void Dispose() {
            brush.Dispose();
            format.Dispose();
        }
    }
}

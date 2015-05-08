
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts {
    using System;
    using System.Drawing;
    using Config;
    using Unit;
    using CheesecakeCardBuilder.Renderer.Text;

    public class DescriptionRenderer {
        private ProjectConfig config;
        private UnitDescription description;
        private Rectangle position;
        private Font font;
        private StringFormat format;
        private Brush brush;
        private TextEffectRenderer fuzzyTextRenderer;

        public DescriptionRenderer(ProjectConfig config, UnitDescription description, Rectangle position) {
            this.config = config;
            this.description = description;
            this.position = position;
            switch (description.type) {
                case UnitDescriptionType.Keyword:
                    this.font = config.keywordFont;
                    break;
                default:
                    this.font = config.descriptionFont;
                    break;
            }
            this.format = new StringFormat();
            this.brush = FontService.getDefaultBrush();
            this.fuzzyTextRenderer = new FuzzyBoxedTextRenderer(font, new Rectangle(position.X + 2, position.Y + 2, position.Width, position.Height), format);
        }

        public SizeF getSizeOfDescription(Graphics graphics) {
            String text = String.Join(" ", description.description);
            return graphics.MeasureString(text, font, position.Size, format);
        }

        public void draw(Graphics graphics){
            String text = String.Join(" ", description.description);
            fuzzyTextRenderer.draw(graphics, text);
            graphics.DrawString(text, font, brush, position);
        }

        public void Dispose() {
            brush.Dispose();
        }
    }
}

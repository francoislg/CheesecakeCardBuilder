﻿
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts {
    using System;
    using System.Drawing;
    using Config;
    using Unit;

    public class DescriptionRenderer {
        private ProjectConfig config;
        private UnitDescription description;
        private Rectangle position;
        private Font font;
        private StringFormat format;
        private Brush brush;

        public DescriptionRenderer(ProjectConfig config, UnitDescription description, Rectangle position) {
            this.config = config;
            this.description = description;
            this.position = position;
            this.font = new Font(config.descriptionFont, config.descriptionFontSize, FontStyle.Regular);
            this.format = new StringFormat();
            this.brush = FontService.getDefaultBrush();
        }

        public SizeF getSizeOfDescription(Graphics graphics) {
            String text = description.description;
            return graphics.MeasureString(text, font, position.Size, format);
        }

        public void draw(Graphics graphics){
            String text = description.description;
            graphics.DrawString(text, font, brush, position);
        }

        public void Dispose() {
            brush.Dispose();
            font.Dispose();
        }
    }
}
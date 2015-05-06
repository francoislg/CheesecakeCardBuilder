﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts {
    using Text;
    public class CardTextRenderer : TextRenderer {
        public Brush brush { get; set; }
        public Font font { get; set; }
        public StringFormat format { get; set; }
        public Point position { get; set; }

        private List<TextEffectRenderer> effects = new List<TextEffectRenderer>();

        public CardTextRenderer() {
            this.brush = FontService.getDefaultBrush();
            this.font = FontService.getDefaultFont();
            this.format = FontService.getDefaultFormat();
        }

        public void addDefaultEffects() {
            effects.Add(new OutlineTextRenderer(font, position, format, new Pen(Color.Black, 1.5f)));
            effects.Add(new FuzzyTextRenderer(font, new Point(position.X + 2, position.Y + 2), format));
        }

        public void addEffect(TextEffectRenderer effectRenderer) {
            effects.Add(effectRenderer);
        }

        public void draw(Graphics graphics, String text) {
            graphics.DrawString(text, font, brush, position, format);
            effects.ForEach(renderer => renderer.draw(graphics, text));
        }
    }
}
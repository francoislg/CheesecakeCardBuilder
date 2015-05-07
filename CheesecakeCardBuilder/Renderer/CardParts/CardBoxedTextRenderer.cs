using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts {
    using Text;
    public class CardBoxedTextRenderer : TextRenderer {
        public Brush brush { get; set; }
        public Font font { get; set; }
        public StringFormat format { get; set; }
        public Rectangle box { get; set; }

        private List<TextEffectRenderer> effects = new List<TextEffectRenderer>();

        public CardBoxedTextRenderer() {
            this.brush = FontService.getDefaultBrush();
            this.font = FontService.getDefaultFont();
            this.format = FontService.getDefaultFormat();
        }

        public void addDefaultEffects() {
            effects.Add(new OutlineBoxedTextRenderer(font, box, format, new Pen(Color.Black, 2.5f)));
            effects.Add(new FuzzyBoxedTextRenderer(font, new Rectangle(box.X + 2, box.Y + 2, box.Width, box.Height), format));
        }

        public void addEffect(TextEffectRenderer effectRenderer) {
            effects.Add(effectRenderer);
        }

        public void changeBrush(Brush brush) {
            this.brush = brush;
        }

        public virtual void draw(Graphics graphics, String text) {
            effects.ForEach(renderer => renderer.draw(graphics, text));
            graphics.DrawString(text, font, brush, box, format);
        }
    }
}

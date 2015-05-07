using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer {
    using Text;
    using CardParts;
    public interface TextRenderer {
        void changeBrush(Brush brush);
        void addEffect(TextEffectRenderer effectRenderer);
        void draw(Graphics graphics, String text);
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer {
    using Text;
    public interface TextRenderer {
        void addEffect(TextEffectRenderer effectRenderer);
        void draw(Graphics graphics, String text);
    }
}

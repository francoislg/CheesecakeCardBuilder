using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer {
    public interface TextRenderer {
        void draw(Graphics graphics, String text);
    }
}

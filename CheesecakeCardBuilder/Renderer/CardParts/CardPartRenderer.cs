using System;
using System.Drawing;

namespace CheesecakeCardBuilder.Renderer.CardParts {
    interface CardPartRenderer {
        void draw(Graphics graphics);
    }
}

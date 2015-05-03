using System;
using System.Drawing;

namespace CheesecakeCardBuilder.Renderer.CardParts {
    public interface CardPartRenderer {
        void draw(Graphics graphics);
    }
}

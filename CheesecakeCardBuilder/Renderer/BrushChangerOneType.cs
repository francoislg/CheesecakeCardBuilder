using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer {
    using CardParts;
    using System.Drawing;
    using CheesecakeCardBuilder.Unit;

    public class BrushChangerOneType : BrushChangerByType {
        private Brush brush;
        public BrushChangerOneType(Brush brush) {
            this.brush = brush;
        }

        public void update(TextRenderer renderer) {
            renderer.changeBrush(brush);
        }
    }
}

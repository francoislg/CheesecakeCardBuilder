using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer {
    using CardParts;
    using System.Drawing;
    using CheesecakeCardBuilder.Unit;

    public class BrushChangerNothing : BrushChangerByType {

        public BrushChangerNothing() {
            
        }

        public void update(TextRenderer renderer) { }
    }
}

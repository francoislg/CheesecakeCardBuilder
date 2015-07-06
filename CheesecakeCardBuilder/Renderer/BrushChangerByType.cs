using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer {
    public interface BrushChangerByType {
        void update(TextRenderer renderer);
    }
}

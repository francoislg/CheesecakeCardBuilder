using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder {
    using System.Drawing;
    public interface CardRenderer {
        Task<Image> generate();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder.Builders {
    using CheesecakeCardBuilder.Unit;
    public interface DescriptionControl {
        String name { get; }
        CardDescription description { get; set; }
        DescriptionType type { get; }
        void clear();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder.Builder.Unit {
    using CheesecakeCardBuilder.Unit;
    public interface UnitDescriptionControl {
        String name { get; }
        UnitDescription description { get; set; }
        UnitDescriptionType type { get; }
        void clear();
    }
}

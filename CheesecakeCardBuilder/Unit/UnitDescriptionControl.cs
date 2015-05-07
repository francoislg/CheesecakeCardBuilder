using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder.Unit {
    public interface UnitDescriptionControl {
        String name { get; }
        UnitDescription description { get; }
        void addUpdater(CardUpdater updater);
    }
}

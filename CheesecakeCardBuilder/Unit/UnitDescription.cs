using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Unit {
    public interface UnitDescription {
        UnitDescriptionType type { get; }
        String name { get; }
        String description { get; }
        void addUpdater(CardUpdater updater);
    }
}

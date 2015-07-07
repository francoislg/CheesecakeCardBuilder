using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Repository {
    using CheesecakeCardBuilder.Unit;
    using CheesecakeCardBuilder.Structure;
    public interface CardRepository {
        List<UnitCard> getAllUnitCards();
        List<StructureCard> getAllStructureCards();
        void save(Card card);
    }
}

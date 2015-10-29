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
        List<CasterCard> getAllCasterCards();
        List<LocationCard> getAllLocationCards();
        List<GearCard> getAllGearCards();
        List<BlessingCard> getAllBlessingCards();
        void save(Card card);
    }
}

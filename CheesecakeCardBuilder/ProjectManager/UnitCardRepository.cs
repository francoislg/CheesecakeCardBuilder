using CheesecakeCardBuilder.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Repository {
    public interface CardRepository {
        List<UnitCard> getAllUnitCards();
        void save(UnitCard card);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheesecakeCardBuilder.ProjectManager;

namespace CheesecakeCardBuilder.Repository {
    using LiteDB;
    using Config;
    using Unit;
    public class LiteDBRepository : CardRepository {
        private ProjectConfig config;
        private LiteDatabase database;
        private LiteCollection<UnitCard> cardsCollection;
        public LiteDBRepository(ProjectConfig config) {
            this.config = config;
            this.database = new LiteDatabase(config.databaseFile);
            this.cardsCollection = database.GetCollection<UnitCard>("cards");
        }

        public List<UnitCard> getAllUnitCards() {
            return cardsCollection.FindAll().ToList<UnitCard>();
        }

        private void update<T>(LiteCollection<T> collection, T card) where T : Card, new(){
            if (collection.Exists(c => c.name.Equals(card.name))) {
                if (!collection.Update(card.name.ToLower(), card)) {
                    throw new CouldNotSaveCardException();
                };
            } else {
                collection.Insert(card);
            }
        }

        public void save(Card card) {
            if (card is UnitCard) {
               update(cardsCollection, (UnitCard)card);
            } else {
                throw new NotSupportedException();
            }
            
        }
    }
}

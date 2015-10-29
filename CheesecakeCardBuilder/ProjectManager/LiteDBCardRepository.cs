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
    using Structure;
    public class LiteDBRepository : CardRepository {
        private ProjectConfig config;
        private LiteDatabase database;
        private LiteCollection<UnitCard> unitsCollection;
        private LiteCollection<StructureCard> structuresCollection;
        private LiteCollection<CasterCard> castersCollection;
        private LiteCollection<LocationCard> locationsCollection;
        private LiteCollection<GearCard> gearsCollection;
        private LiteCollection<BlessingCard> blessingsCollection;
        public LiteDBRepository(ProjectConfig config) {
            this.config = config;
            this.database = new LiteDatabase(config.databaseFile);
            this.unitsCollection = database.GetCollection<UnitCard>("units");
            this.structuresCollection = database.GetCollection<StructureCard>("structures");
            this.castersCollection = database.GetCollection<CasterCard>("casters");
            this.locationsCollection = database.GetCollection<LocationCard>("locations");
            this.gearsCollection = database.GetCollection<GearCard>("gears");
            this.blessingsCollection = database.GetCollection<BlessingCard>("blessings");
        }

        public List<UnitCard> getAllUnitCards() {
            return unitsCollection.FindAll().ToList<UnitCard>();
        }

        public List<StructureCard> getAllStructureCards() {
            return structuresCollection.FindAll().ToList<StructureCard>();
        }

        public List<CasterCard> getAllCasterCards() {
            return castersCollection.FindAll().ToList<CasterCard>();
        }

        public List<LocationCard> getAllLocationCards() {
            return locationsCollection.FindAll().ToList<LocationCard>();
        }

        public List<GearCard> getAllGearCards() {
            return gearsCollection.FindAll().ToList<GearCard>();
        }

        public List<BlessingCard> getAllBlessingCards() {
            return blessingsCollection.FindAll().ToList<BlessingCard>();
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
               update(unitsCollection, (UnitCard)card);
            } else if (card is StructureCard) {
                update(structuresCollection, (StructureCard)card);
            } else if (card is CasterCard) {
                update(castersCollection, (CasterCard)card);
            } else if (card is LocationCard) {
                update(locationsCollection, (LocationCard)card);
            } else if (card is GearCard) {
                update(gearsCollection, (GearCard)card);
            } else if (card is BlessingCard) {
                update(blessingsCollection, (BlessingCard)card);
            } else {
                throw new NotSupportedException();
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            IEnumerable<UnitCard> cards = cardsCollection.FindAll();
            List<UnitCard> listCards = new List<UnitCard>();
            foreach(UnitCard card in cards){
                listCards.Add(card);
            }
            return listCards;
        }

        public void save(UnitCard card) {
            if (cardsCollection.Exists(c => c.name.Equals(card.name))) {
                cardsCollection.Update(card);
            } else {
                cardsCollection.Insert(card);
            }
        }
    }
}
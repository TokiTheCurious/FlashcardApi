using Service.BusinessLogic.Interfaces;
using Service.Database;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.BusinessLogic
{
    public class CardService : ICardService
    {
        ICardRepository Repository;
        public CardService(ICardRepository repo)
        {
            Repository = repo;
        }

        public IEnumerable<Card> GetCards(int deckId)
        {
            return Repository.GetCards(deckId);
        }
    }
}

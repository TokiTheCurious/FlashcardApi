using Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Database
{
    public interface ICardRepository : IRepository
    {
        IEnumerable<Card> GetCards(int deckId);
    }
}

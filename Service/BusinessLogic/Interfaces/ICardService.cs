using Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.BusinessLogic.Interfaces
{
    public interface ICardService
    {
        IEnumerable<Card> GetCards(int deckId);
    }
}

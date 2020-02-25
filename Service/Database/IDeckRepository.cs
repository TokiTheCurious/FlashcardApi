using Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Database
{
    public interface IDeckRepository : IRepository
    {
        IEnumerable<Deck> GetAllDecks();
        IEnumerable<Deck> GetDecksByUserId(int userId);
        
    }
}

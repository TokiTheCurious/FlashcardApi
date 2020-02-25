using Service.BusinessLogic.Interfaces;
using Service.Database;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.BusinessLogic
{
    public class DeckService : IDeckService
    {
        IDeckRepository Repository;

        public DeckService(IDeckRepository _repo)
        {
            Repository = _repo;
        }

        public IEnumerable<Deck> GetAllDecks()
        {
            return Repository.GetAllDecks();
        }

        public IEnumerable<Deck> GetDecksByUserId(int id)
        {
            return Repository.GetDecksByUserId(id);
        }
    }
}

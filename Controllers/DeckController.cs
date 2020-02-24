using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlashcardApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FlashcardApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeckController : ControllerBase
    {
        private static readonly Deck[] Decks = new[]
        {
            new Deck{Id=1, User_Id= 1},
            new Deck{Id=2, User_Id= 1},
            new Deck{Id=3, User_Id= 1},
            new Deck{Id=4, User_Id= 2},

        };

        [HttpGet]
        public IEnumerable<Deck> GetDecks()
        {
            return Decks;
        }

        [HttpGet("byUserId")]
        public IEnumerable<Deck> GetByUserId(int user_id)
        {
            return Decks.Where(d => d.User_Id == user_id);
        }
    }
}
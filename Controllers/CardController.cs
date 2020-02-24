using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlashcardApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlashcardApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private static readonly Card[] Cards = new[]
        {
            new Card{Id = 234234,Deck_Id=4, Front="another card", Back= "another card back"},
            new Card{Id = 1,Deck_Id=1, Front="first card", Back= "first card answer"},
            new Card{Id = 2,Deck_Id=2, Front="second card", Back= "second card answer"},
            new Card{Id = 3,Deck_Id=3, Front="third card", Back= "third card answer"},
            new Card{Id = 4,Deck_Id=4, Front="fourth card", Back= "fourth card answer"},
        };

        [HttpGet]
        public IEnumerable<Card> GetCards()
        {
            return Cards;
        }

        [HttpGet("byDeckId")]
        public IEnumerable<Card> GetByUserId(int deck_id)
        {
            return Cards.Where(d => d.Deck_Id == deck_id);
        }
    }
}
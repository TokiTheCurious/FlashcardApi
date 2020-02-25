using System;
using System.Collections.Generic;
using System.Linq;
using FlashcardApi.Models;
using Microsoft.AspNetCore.Mvc;
using Service.BusinessLogic.Interfaces;
using Service.Models;

namespace FlashcardApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        ICardService Service;

        public CardController(ICardService service)
        {
            Service = service;
        }



        [HttpGet("byDeckId")]
        public IEnumerable<Card> GetByUserId(int deck_id)
        {
            return Service.GetCards(deck_id);
        }
    }
}
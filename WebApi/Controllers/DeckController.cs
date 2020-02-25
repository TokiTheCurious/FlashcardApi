using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlashcardApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.BusinessLogic;
using Service.BusinessLogic.Interfaces;
using Service.Models;

namespace FlashcardApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeckController : ControllerBase
    {
        IDeckService service;
        public DeckController(IDeckService _service)
        {
            service = _service;
        }

        [HttpGet]
        public IEnumerable<Deck> GetDecks()
        {
            return service.GetAllDecks();
        }

        [HttpGet("byUserId")]
        public IEnumerable<Deck> GetByUserId(int user_id)
        {
            return service.GetDecksByUserId(user_id);
        }
    }
}
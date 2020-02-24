using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashcardApi.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }
        public int Deck_Id { get; set; }

    }
}

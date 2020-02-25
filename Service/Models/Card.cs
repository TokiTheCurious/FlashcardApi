using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Models
{
    public class Card
    {
        public int Id { get; set; }
        public int DeckId { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }
    }
}

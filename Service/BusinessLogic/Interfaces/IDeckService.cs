﻿using Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.BusinessLogic.Interfaces
{
    public interface IDeckService
    {
        IEnumerable<Deck> GetAllDecks();
        IEnumerable<Deck> GetDecksByUserId(int id);


    }
}

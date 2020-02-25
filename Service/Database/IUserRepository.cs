using Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Database
{
    public interface IUserRepository : IRepository
    {
        User GetUserById(int id);
    }
}

using Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Sql
{
    interface IUserRepository
    {
        User GetUserById(int id);
    }
}

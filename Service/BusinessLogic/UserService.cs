using Service.BusinessLogic.Interfaces;
using Service.Database;
using Service.Models;
using Service.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.BusinessLogic
{
    public class UserService : IUserService
    {
        IUserRepository Repository;


        public UserService(IUserRepository repo)
        {
            Repository = repo;
        }


        public User Login(string accountName, string password)
        {
            throw new NotImplementedException();
        }

        public User CreateUser(User user, string password)
        {
            //Check if user already exists -- if so return user data with 304 not modified
            //If user doesn't exist create and return user data -- 200 ok
            //On failure figure out what to return -- 400-500+

            throw new NotImplementedException();
        }
    }
}

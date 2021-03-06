using NUnit.Framework;
using Service.Models;
using System;

namespace Persistence.Sql.Test
{
    public class UserRepository_Tests
    {
        string connectionString = @"Server=localhost;Database=Flashcards;User Id=sa; password=yourStrong(!)Password";
        UserRepository userRepo;
        [SetUp]
        public void Setup()
        {
            userRepo = new UserRepository(new Service.Settings.ConnectionSettings {ConnectionString = connectionString });
        }

        [Test]
        public void GetUserById_Test()
        {
            var result = userRepo.GetUserById(1);
            var expected = new User { Id = 1, FirstName = "John", LastName = "Doe", DateCreated = DateTime.Parse("2020-02-24") };
            Assert.AreEqual(result.Id, expected.Id);
            
        }
    }
}
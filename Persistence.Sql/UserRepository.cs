using Service.Models;
using System;
using System.Data.SqlClient;

namespace Persistence.Sql
{
    public class UserRepository : IUserRepository
    {
        public User GetUserById(int userId)
        {
            User user;
            using (SqlConnection con = Repository.OpenConnection())
            {
                con.Open();
                
                var query = "select id, firstname, lastname, datecreated from dbo.tbUser where id = @UserId";
                var dbCommand = new SqlCommand(query, con);
                dbCommand.Parameters.AddWithValue("@UserId", userId);

                using (var reader = dbCommand.ExecuteReader())
                {
                    reader.Read();
                    user = new User
                    {
                        Id = (int)reader[0],
                        FirstName = (string)reader[1],
                        LastName = (string)reader[2],
                        DateCreated = DateTime.Parse(reader[3].ToString())
                    };
                }

                    con.Close();
            }
            return user;
        }
    }
}

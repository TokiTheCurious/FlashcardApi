using Service.Database;
using Service.Models;
using Service.Settings;
using System;
using System.Data.SqlClient;

namespace Persistence.Sql
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(ConnectionSettings conn): base(conn){}

        public User GetUserById(int userId)
        {
            User user;
            using (SqlConnection con = OpenConnection())
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

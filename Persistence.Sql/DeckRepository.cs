using Service.Database;
using Service.Models;
using Service.Settings;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Persistence.Sql
{
    public class DeckRepository :  BaseRepository, IDeckRepository
    {

        public DeckRepository(ConnectionSettings conSettings): base(conSettings) { }

        public IEnumerable<Deck> GetAllDecks()
        {
            List<Deck> Decks = new List<Deck>();
            using (SqlConnection con = OpenConnection())
            {
                con.Open();

                var query = "select id, user_id from dbo.tbDeck";
                var dbCommand = new SqlCommand(query, con);

                using (var reader = dbCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Decks.Add(new Deck
                        {
                            Id = (int)reader[0],
                            UserId = (int)reader[1]
                        }
                        );
                    }
                }

                con.Close();
            }
            return Decks;
        }

        public IEnumerable<Deck> GetDecksByUserId(int userId)
        {
            List<Deck> Decks = new List<Deck>();
            using (SqlConnection con = OpenConnection())
            {
                con.Open();

                var query = "select id, user_id from dbo.tbDeck where user_id = @UserId";
                var dbCommand = new SqlCommand(query, con);
                dbCommand.Parameters.AddWithValue("@UserId", userId);

                using (var reader = dbCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Decks.Add(new Deck
                        {
                            Id = (int)reader[0],
                            UserId = (int)reader[1]
                        }
                        );
                    }
                }

                con.Close();
            }
            return Decks;
        }
    }
}

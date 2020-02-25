using Service.Database;
using Service.Models;
using Service.Settings;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Persistence.Sql
{
    public class CardRepository : BaseRepository, ICardRepository
    {
        public CardRepository(ConnectionSettings conSettings) : base(conSettings) { }

        public IEnumerable<Card> GetCards(int deckId)
        {
            List<Card> Cards = new List<Card>();
            using (SqlConnection con = OpenConnection())
            {
                con.Open();

                var query = "select id,deck_id,front,back from dbo.tbCard where deck_id = @DeckId";
                var dbCommand = new SqlCommand(query, con);
                dbCommand.Parameters.AddWithValue("@DeckId", deckId);

                using (var reader = dbCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cards.Add(new Card
                        {
                            Id = (int)reader[0],
                            DeckId = (int)reader[1],
                            Front = reader[2].ToString(),
                            Back = reader[3].ToString()
                        }
                        );
                    }
                }

                con.Close();
            }
            return Cards;
        }
    }
}

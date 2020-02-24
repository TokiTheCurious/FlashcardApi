using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Persistence.Sql
{
    public class Repository
    {
        protected static string ConnectionString;

        public Repository(string conString)
        {
            ConnectionString = conString;
        }

        public static SqlConnection OpenConnection()
        {
            return new SqlConnection(ConnectionString);
        }

    }
}

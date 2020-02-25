using Service.Settings;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Persistence.Sql
{
    public class BaseRepository
    {
        protected ConnectionSettings connectionSettings;

        public BaseRepository(ConnectionSettings conString)
        {
            connectionSettings = conString;
        }

        public SqlConnection OpenConnection()
        {
            return new SqlConnection(connectionSettings.ConnectionString);
        }

    }
}

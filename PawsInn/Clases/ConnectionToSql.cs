using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PawsInn.Clases
{
    internal class ConnectionToSql
    {
        private readonly string connectionString;

        public ConnectionToSql()
        {
            connectionString = @"Data Source=DESKTOP-65QG3G0\SQLEXPRESS; Initial Catalog=PawsInn; Integrated Security=True;Connect Timeout=30";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LINQ_Beginner
{
    internal class GetConnection
    {
        public SqlConnection GetSqlConnection()
        {
            string ConnectionString = "Data source = localhost; " + "Initial Catalog = FroggyInc; User = sa; password =sa;";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            return sqlConnection;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LinQ_CRUD
{
    internal class ConnectDB
    {
        public SqlConnection ConnectToDB()
        {
            string ConnectionString = "Data source = localhost; " + "Initial Catalog = LinqDB; User = sa; password =sa;";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            return sqlConnection;
        }
    }
}

using System.Linq;
using System.Data.SqlClient;


namespace LINQExcersise {
    internal class ConnectDb
    {
        public SqlConnection GetSqlConnection()
        {
            string ConnectionString = "Data source = localhost; " + "Initial Catalog = FroggyInc; User = sa; password =sa;";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            return sqlConnection;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CRUD_In_CSharp
{
    internal class Model
    {
       
        

        public static void GetData()
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.ConnectToDB();
            string query = "select * from Products";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader(); //read-only
            while (reader.Read())
            {
                Console.WriteLine("Product ID: " + reader[0]);
                Console.WriteLine("Product Name: " + reader[1]);
                Console.WriteLine("Product Price: " + reader[2]);
            }
            conn.Close();
        }

        public static void CreateData()
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.ConnectToDB();
            Console.Write("Input a product's name: ");
            string nameInput = Console.ReadLine();
            Console.Write("Input a product's description: ");
            string descInput = Console.ReadLine();
            Console.Write("Input a product's price: ");
            string priceInput = Console.ReadLine();
            string query = "insert into Products values(@proName,@proDesc,@proPrice)";
            SqlCommand command = new SqlCommand(query, conn);
            SqlParameter productName = new SqlParameter("@proName",nameInput);
            SqlParameter productDesc = new SqlParameter("@proDesc", descInput);
            SqlParameter productPrice = new SqlParameter("@proPrice", priceInput);
            command.Parameters.Add(productName);
            command.Parameters.Add(productDesc);
            command.Parameters.Add(productPrice);
            conn.Open();
            int DataCount = command.ExecuteNonQuery();
            Console.WriteLine("Insert {0} du lieu thanh cong", DataCount);
            conn.Close();
        }

        public static void UpdateData()
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.ConnectToDB();
            Console.Write("Column's name that you want to update: ");
            string colNameInput = Console.ReadLine();
            Console.Write("What value do you want to change this column to: ");
            string changeParamInput = Console.ReadLine();
            Console.Write("Enter the condition column: ");
            string secondColNameInput = Console.ReadLine();
            Console.Write("Enter the condition param: ");
            string conditionParamInput = Console.ReadLine();
            string query = "update Products set @colName = @changeParam where @secondColName = @conditionParam";
            SqlCommand command = new SqlCommand(query, conn);
            SqlParameter colName = new SqlParameter("@colName", colNameInput);
            SqlParameter changeParam = new SqlParameter("@changeParam", changeParamInput);
            SqlParameter secondColName = new SqlParameter("@secondColName", secondColNameInput);
            SqlParameter conditionParam = new SqlParameter("@conditionParam", conditionParamInput);
            command.Parameters.Add(colName);
            command.Parameters.Add(changeParam);
            command.Parameters.Add(secondColName);
            command.Parameters.Add(conditionParam);
            conn.Open();
            int DataCount = command.ExecuteNonQuery();
            Console.WriteLine("Da update {0} san pham", DataCount);
            conn.Close();
        }

        public static void DeleteData()
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.ConnectToDB();
        }
        public static void Main(string[] args)
        {
            CreateData();
        }
    }
}

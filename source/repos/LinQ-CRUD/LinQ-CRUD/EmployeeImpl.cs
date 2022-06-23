using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LinQ_CRUD
{
    internal class EmployeeImpl
    {



        public List<Employee> GetEmployeeData()
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.ConnectToDB();
            List<Employee> employees = new List<Employee>();
            string query = "select * from Employee";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(reader[0]);
                emp.EmployeeName = Convert.ToString(reader[1]);
                employees.Add(emp);
            }
            List<Employee> empProQ1 = employees.Where(emp => emp.EmployeeName.StartsWith("")).ToList();
            foreach (Employee employee in empProQ1)
            {
                Console.WriteLine(employee.EmployeeName);
            }
            return empProQ1;
        }

        public static void CreateData()
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.ConnectToDB();
            Console.Write("Input a product's name: ");
            string nameInput = Console.ReadLine();
            string query = "insert into Employee values(@empName)";
            SqlCommand command = new SqlCommand(query, conn);
            SqlParameter EmployeeName = new SqlParameter("@empName", nameInput);
            command.Parameters.Add(EmployeeName);
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
            EmployeeImpl employeeImpl = new EmployeeImpl();
            employeeImpl.GetEmployeeData();
        }
    }
}

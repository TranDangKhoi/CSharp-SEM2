using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LINQExcersise
{
    internal class EmployeeDAO
    {
        public List<Employee> GetEmployeeData()
        {
            ConnectDb connectDb = new ConnectDb();
            SqlConnection conn = connectDb.GetSqlConnection();
            List<Employee> employees = new List<Employee>();
            string query = "select * from Employee";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.employeeID = Convert.ToInt32(reader[0]);
                emp.employeeName = Convert.ToString(reader[1]);
                emp.projectID = Convert.ToInt32(reader[2]);
                employees.Add(emp);
                Console.WriteLine(emp.toString());
            }
            return employees;
        }

        public static void Main(string[] args)
        {
            EmployeeDAO empDAO = new EmployeeDAO();
            empDAO.GetEmployeeData();
        }
    }
}

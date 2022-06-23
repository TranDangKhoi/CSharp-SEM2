using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace LINQ_Beginner
{
    internal class Program
    {
        public static List<Project> projects = new List<Project>();
        public static List<Employee> employees = new List<Employee>();
        public static void Main(string[] args)
        {
            InitProject(); // Khoi tao gia tri mau aka data seeder
            InitEmployee();
            List<Employee> empProQ1 = (from emp in employees
                                       where emp.EmployeeName.StartsWith("M")
                                       select emp).ToList();
            foreach(Employee name in empProQ1)
            {
                Console.WriteLine(name.EmployeeName);
            }
            // Shorter query

            var empProQ2 = employees.Where(emp => emp.EmployeeName.StartsWith("K"));
        }

        public static void InitProject()
        {
            projects.Add(new Project { ProjectID = 1, ProjectName = "Lecka"});
            projects.Add(new Project { ProjectID = 2, ProjectName = "Trello" });
        }

        public static void InitEmployee()
        {
            employees.Add(new Employee { EmployeeId = 101, EmployeeName = "Khoi", ProjectID = 1 });
            employees.Add(new Employee { EmployeeId = 102, EmployeeName = "Minh", ProjectID = 1 });
            employees.Add(new Employee { EmployeeId = 102, EmployeeName = "Manh", ProjectID = 1 });
            employees.Add(new Employee { EmployeeId = 103, EmployeeName = "Viet", ProjectID = 2 });
            employees.Add(new Employee { EmployeeId = 104, EmployeeName = "Nam", ProjectID = 2 });
        }
    }
}



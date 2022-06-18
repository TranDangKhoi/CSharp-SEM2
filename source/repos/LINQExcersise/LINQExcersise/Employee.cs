using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExcersise
{
    internal class Employee
    {
        public int employeeID { get; set; }
        public string employeeName { get; set; }
        public int projectID { get; set; }

        public string toString()
        {
            return "Employee's ID:" + employeeID + "\n" + "Employee's Name:" + employeeName + "\n" + "Project's ID: " + projectID;
        }
    }
}

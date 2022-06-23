using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_CRUD
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public string toString()
        {
            return "Employee's ID:" + EmployeeId + "\n" + "Employee's Name:" + EmployeeName + "\n";
        }
    }
}

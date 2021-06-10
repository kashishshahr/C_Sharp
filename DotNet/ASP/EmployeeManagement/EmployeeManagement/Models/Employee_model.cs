using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public String EmployeeName { get; set; }
        public String EmployeeEmail { get; set; }
        public String EmployeeDepartment { get; set; }
    }
}

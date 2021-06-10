using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepositary : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepositary()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){EmployeeId=1,EmployeeName="Mary",EmployeeDepartment="HR",EmployeeEmail="mary@gmail.com"},
                new Employee(){EmployeeId=2,EmployeeName="John",EmployeeDepartment="IT",EmployeeEmail="john@gmail.com"},
                new Employee(){EmployeeId=3,EmployeeName="Sam",EmployeeDepartment="IT",EmployeeEmail="sam@gmail.com"},
            };
        }
        public Employee GetEmployee(int EmpId)
        {
            Employee e = _employeeList.FirstOrDefault<Employee>(E => E.EmployeeId == EmpId);
            return e;
        }
    }
}

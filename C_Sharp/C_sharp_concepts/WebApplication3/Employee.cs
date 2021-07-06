using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Company
    {
        private List<Employee> listEmployees;
        public string this[int employeeId] { get 
                {
                    return listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).EmployeeName;
                }
                set 
                {
                listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).EmployeeName=value;
            } 
            }
        public string this[string gender] 
        { 
            get 
                {
                    return listEmployees.Count(emp => emp.EmployeeGender == gender).ToString();
                }
            set
            {
                foreach (Employee emp in listEmployees)
                {
                    if(emp.EmployeeGender==gender)
                    {
                        emp.EmployeeGender = value;
                    }
                }
            }
        }
        public Company()
        {
            listEmployees = new List<Employee>() ;
            listEmployees.Add(new Employee() { EmployeeId = 1, EmployeeName = "Mike", EmployeeGender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 2, EmployeeName = "Pam", EmployeeGender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 3, EmployeeName = "John", EmployeeGender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 4, EmployeeName = "Maxine", EmployeeGender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 5, EmployeeName = "Emily", EmployeeGender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 6, EmployeeName = "Scott", EmployeeGender = "Male" });
        }
    }
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeGender { get; set; }
    }
}
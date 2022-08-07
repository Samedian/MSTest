using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MSTest
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }


        public int YearOfExperience { get; set; }

        public string EmployeeLastCompany { get; set; }

        public bool IsFresher(Employee employee)
        {
            if (employee.YearOfExperience > 0)
                return true;
            return false;
        }

        public string EmployeeFullName(Employee employee)
        {
            if (employee != null)
                return employee.EmployeeFirstName + " " + employee.EmployeeLastName;

            return null;
        }
        public int EmployeeSalary(Employee employee)
        {
            if (employee == null)
                throw new CustomException("Employee Null");

            return (10000) + (10000 * employee.YearOfExperience * 10 / 100);
        }

        public List<Employee> EmployeeFresher(List<Employee> employee)
        {
            return employee.FindAll(x => x.YearOfExperience == 0);
        }
    }
}

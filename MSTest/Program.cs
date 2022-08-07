using System;

namespace MSTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { 
                EmployeeId = 1,
                EmployeeFirstName = "Samarth", 
                EmployeeLastName="Goel",
                YearOfExperience = 0
            };
            employee.EmployeeFullName(null);
            Console.WriteLine(employee.IsFresher(employee));
            Console.ReadLine();
        }
    }
}

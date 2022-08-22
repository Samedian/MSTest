using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Ignore]// will not execute
        //For Bool Values
        public void IsFresher()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 1,
                EmployeeFirstName = "Samarth",
                EmployeeLastName = "Goel",
                YearOfExperience = 0,
                EmployeeLastCompany = string.Empty
            };
            var result = employee.IsFresher(employee);
            Assert.IsFalse(result); // similarly we have IsTrue

        }


        [TestMethod]
        [PlayDefault]
        public void EmployeeSalary()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 1,
                EmployeeFirstName = "Samarth",
                EmployeeLastName = "Goel",
                YearOfExperience = 2,
                EmployeeLastCompany = string.Empty
            };
            var result = employee.EmployeeSalary(employee);
            Assert.AreEqual(12000, result);
        }

        [TestMethod]
        [PlayDefault]
        //For Null Values
        public void EmployeeFullNameNull()
        {
            Employee employee = new Employee();
            var result = employee.EmployeeFullName(null);
            Assert.IsNull(result); // similarly we have isnotnull

        }

        [TestMethod]
        //For Simple String 
        public void EmployeeFullName()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 1,
                EmployeeFirstName = "Samarth",
                EmployeeLastName = "Goel",
                YearOfExperience = 0,
                EmployeeLastCompany = string.Empty
            };
            var result = employee.EmployeeFullName(employee);
            Assert.AreEqual("Samarth Goel", result);
            //For case in-sensitive Assert.AreEqual("Samarth Goel", result, true);
        }

        [TestMethod]
        //For Simple String 
        public void EmployeeNameStart()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 1,
                EmployeeFirstName = "Samarth",
                EmployeeLastName = "Goel",
                YearOfExperience = 0,
                EmployeeLastCompany = string.Empty
            };
            StringAssert.StartsWith(employee.EmployeeFirstName, "Sam");
            //similarly we have EndsWith and contains
        }

        [TestMethod]
        public void RegularExpression()
        {
            Employee employee = new Employee();
            employee.EmployeeFirstName = "Sarah";
            employee.EmployeeLastName = "Smith";
            StringAssert.Matches(employee.EmployeeFirstName, new Regex("[A-Z]||[a-z] +[A-Z]{1}[a-z]+"));
        }



        [TestMethod]
        [TestCategory("List")]
        public void CollectionAssertCheck()
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee{EmployeeFirstName="Sarah",EmployeeLastName="Smith"},
                new Employee{EmployeeFirstName="Alexa",EmployeeLastName="Joe"}
            };
            CollectionAssert.Contains(list, list.Find(x => x.EmployeeLastName=="Joe"));
            //DoesNotContains
        }

        [TestMethod]
        [TestCategory("List")]
        public void TwoCollectionAssertCheck()
        {
            Employee employee = new Employee();
            List<Employee> employees = new List<Employee>()
            {
                new Employee{EmployeeFirstName="Sarah",EmployeeLastName="Smith",YearOfExperience=0},
                new Employee{EmployeeFirstName="Alexa",EmployeeLastName="Joe",YearOfExperience=2},
                new Employee{EmployeeFirstName="Sam",EmployeeLastName="Joe",YearOfExperience=0},

            };

            List<Employee> employeesFresher = employee.EmployeeFresher(employees);
            CollectionAssert.AreEqual(employeesFresher, employees.FindAll(x=>x.YearOfExperience==0)); //check sequence
            //AreEquivalent doesn't check order
            //AllItemsAreUnique
            //Assert.IsTrue(list1.any(x=>x.contains()))
        }

        [TestMethod]
        public void Exception()
        {
            Employee employee = new Employee();
            Assert.ThrowsException<CustomException> (() => employee.EmployeeSalary(null));

        }

        [TestMethod]
        public void Type()
        {
            Employee employee = new Employee();
            Assert.IsInstanceOfType(employee, typeof(Employee));

            //AreSame & not same also (obj1,obj2) 

        }
    }
}

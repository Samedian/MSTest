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
        public void Numeric()
        {
            Prime prime = new Prime();
            var result = prime.IsPrime(7);

            Assert.AreEqual(7,result);
        }

        [TestMethod]
        public void StringCheck()
        {
            Person person = new Person();
            person.FName = "Sarah";
            person.LName = "Smith";
            StringAssert.Matches(person.FName, new Regex("[A-Z]||[a-z] +[A-Z]{1}[a-z]+"));
        }

        public void List()
        {
            List<Person> list = new List<Person>()
            {
                new Person{FName="Sarah",LName="Smith"},
                new Person{FName="Alexa",LName="Joe"}
            };

            CollectionAssert.Contains(list, "Sarah Smith");
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class LifeCycle
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext testContext)
        {
            Console.WriteLine(" Assembly Initializer");
        }
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            Console.WriteLine(" Class Initializer");
        }

        [TestInitialize]
        public void TestInit()
        {
            Console.WriteLine(" Test Initializer");
        }
        [TestMethod]
        public void TestA()
        {
            Console.WriteLine("Test A");
        }

        [TestMethod]
        public void TestB()
        {
            Console.WriteLine("Test B");
        }
        [TestCleanup]
        public void TestCleanUp()
        {
            Console.WriteLine(" Test Clean Up");
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            Console.WriteLine(" Class Clean Up");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanUp()
        {
            Console.WriteLine(" Assembly Clean Up ");
        }
    }
}

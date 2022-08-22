using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class DamageTest
    {
        Damage dam;
        //Code Refactoring
        [TestInitialize]
        public void TestInit()
        {
            dam = new Damage();
        }
        //Normal
        [TestMethod]
        [DataTestMethod]
        [DataRow(1,99)]
        [DataRow(0,100)]
        [DataRow(50,50)]
        [DataRow(101,1)]
        public void TestDamage(int damage,int expected)
        {
            var res = dam.CalculateDamage(damage);

            Assert.AreEqual(expected, res);
        }

        #region List 
        public static IEnumerable<object[]> DamagesList
        {
            get
            {
                return new List<object[]>
                {
                    new object[]{1,99},
                    new object[]{0,100 },
                    new object[]{50,50 },
                    new object[]{101,1 },

                };
            }
        }
        [DataTestMethod]
        [DynamicData(nameof(DamagesList))]
        public void TestDamageList(int damage, int expected)
        {
            var res = dam.CalculateDamage(damage);

            Assert.AreEqual(expected, res);
        }
        #endregion

        #region Method 
        public static IEnumerable<object[]> GetDamages()
        {
            return new List<object[]>
                {
                    new object[]{1,99},
                    new object[]{0,100 },
                    new object[]{50,50 },
                    new object[]{101,1 },

            };
        }
        [DataTestMethod]
        [DynamicData(nameof(GetDamages),DynamicDataSourceType.Method)]
        public void TestDamageMethod(int damage, int expected)
        {
            var res = dam.CalculateDamage(damage);

            Assert.AreEqual(expected, res);
        }
        #endregion

        #region External Class 

        [DataTestMethod]
        [DynamicData(nameof(DamageData.GetExtDamages),typeof(DamageData), DynamicDataSourceType.Method)]
        public void TestDamageExternalClass (int damage, int expected)
        {
            var res = dam.CalculateDamage(damage);

            Assert.AreEqual(expected, res);
        }
        #endregion

        #region CSV 

        [DataTestMethod]
        //[DynamicData(nameof(DamageDataCSV.TestData), typeof(DamageDataCSV))]
        [CSVDataSource("Damage.csv")]
        //Prop of csv - do not copy to newer
        public void TestDamageCSV(int damage, int expected)
        {
            var res = dam.CalculateDamage(damage);

            Assert.AreEqual(expected, res);
        }
        #endregion
    }
}

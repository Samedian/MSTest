using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UnitTestProject1
{
    public class DamageDataCSV
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                string[] csvLines = File.ReadAllLines("Damage.csv");
                var testCases = new List<object[]>();

                foreach (var csvLine in csvLines)
                {
                    IEnumerable<int> val = csvLine.Split(',').Select(int.Parse);
                    object[] testCase = val.Cast<object>().ToArray();
                    testCases.Add(testCase);

                }

                return testCases;
            }
        }
    }
}

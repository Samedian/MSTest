using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace UnitTestProject1
{
    public class CSVDataSourceAttribute : Attribute, ITestDataSource
    {
        public string FileName;
        public CSVDataSourceAttribute(string fileName)
        {
            FileName = fileName;
        }
        IEnumerable<object[]> ITestDataSource.GetData(MethodInfo methodInfo)
        {
            string[] csvLines = File.ReadAllLines(FileName);
            var testCases = new List<object[]>();

            foreach (var csvLine in csvLines)
            {
                IEnumerable<int> val = csvLine.Split(',').Select(int.Parse);
                object[] testCase = val.Cast<object>().ToArray();
                testCases.Add(testCase);

            }

            return testCases;
        }

        string ITestDataSource.GetDisplayName(MethodInfo methodInfo, object[] data)
        {
            if (data == null)
                return null;

            return $"{methodInfo.Name} ({string.Join(",",data)})";
        }
    }
}

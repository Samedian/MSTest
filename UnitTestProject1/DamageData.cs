using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1
{
    public class DamageData
    {
        public static IEnumerable<object[]> GetExtDamages()
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
}

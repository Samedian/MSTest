using System;
using System.Collections.Generic;
using System.Text;

namespace MSTest
{
    public class Damage
    {
        public int CalculateDamage(int damage)
        {
            return Math.Max(1, 100 - damage);
        }
    }
}

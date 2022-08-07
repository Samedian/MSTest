using System;
using System.Collections.Generic;
using System.Text;

namespace MSTest
{
    public class CustomException : Exception
    {
        public CustomException(string msg) :base(msg)
        {
                
        }
    }
}

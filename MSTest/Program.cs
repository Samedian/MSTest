using System;

namespace MSTest
{
    public class Person
    {
        public string FName { get; set; }

        public string LName { get; set; }

    }
    public class Prime
    {
        public int IsPrime(int num)
        {
            for (int index = 2; index <= num / 2; index++)
            {
                if (num % index == 0)
                    return index;
            }

            return num;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }
}

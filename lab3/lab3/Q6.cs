using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Q6
    {
        public static void Main(string[] args)
        {
            int n = 10;

            Console.WriteLine("Original value: " + n);
            int r = PassByValue(n);
            Console.WriteLine("Value after pass by value:" + n + "(original), " + r + " (returned)");

            PassByReference(ref n);
            Console.WriteLine("Value after pass by reference: " + n);
            Console.ReadKey();
        }

        static int PassByValue(int n)
        {
            n++;
            return n;
        }
        static void PassByReference(ref int n)
        {
            n++;
        }
    }
}

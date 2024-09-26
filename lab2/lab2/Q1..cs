using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the any number:");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0) {
                Console.WriteLine("The given number is even");

            }
            else
            {
                Console.WriteLine("the given number is odd");
            }
            Console.ReadKey();
    }
    }
}
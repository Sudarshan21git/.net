//WRITE A c# to test whether give n number is positive or negative and zero.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" enter the any number:");
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("the given number is zero");
            }
            else if (n > 0)
            {
                Console.WriteLine("the given number is positive");
            }
            else
            {
                Console.WriteLine("the give number is negative");

            }
            Console.ReadKey();
        }
    }
}
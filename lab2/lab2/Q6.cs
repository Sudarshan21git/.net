//write a c# program to check whether given number is armstrong or not:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the any number:");
            int n = int.Parse(Console.ReadLine());
            int r, c, arm = 0;
            c = n;
            while (n > 0)
            {
                r = n % 10;
                arm = arm + (r * r * r);
                n=n / 10;
            }
            if (arm == c)
            {
                Console.WriteLine("the given number is armstrong number:");
            }
            else
            {
                Console.WriteLine("the given number is not armstrong number:");
            }
            Console.ReadKey();
        }
    }
}

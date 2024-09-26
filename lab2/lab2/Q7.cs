//Q7.write a c# program to chck the input number is perfect of or not?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the any number:");
            int n=int.Parse(Console.ReadLine());
            int sum = 0,i;
            for (i = 1; i < n; i++)
            {
                if(n %i == 0)
                    sum=sum+i;
            }
            if (n == sum)
            {
                Console.WriteLine("the given number is perfect number");
            }
            else
            {
                Console.WriteLine("the given number is not perfect number");
            }
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11 };
            for (int i = 0; i < arr.Length; i++)
            
                {
                    if (arr[i] % 2 != 0)
                    {
                        sum = sum + arr[i];
                    }

                
            }
                Console.WriteLine("The sum of odd number is:"+sum);

            
            Console.ReadKey();
        }
    }
}

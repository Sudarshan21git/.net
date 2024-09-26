using System;

namespace lab2
{
    internal class Q5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            // Adjust the loop to check divisors correctly
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                Console.WriteLine("The given number is a prime number.");
            }
            else
            {
                Console.WriteLine("The given number is not a prime number.");
            }

            Console.ReadKey();
        }
    }
}

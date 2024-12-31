using System;

namespace lab6
{
    public class Practice
    {
        public delegate double ciDelegate(double p, double r, double y);
    }

    public class pp
    {
        public static void Main()
        {
            Practice.ciDelegate del = delegate (double p, double r, double y)
            {
                double a = (p > r) ? (p > y ? p : y) : (r > y ? r : y);
                return a;
            };

            double result = del(1, 5, 2);
            Console.WriteLine("Greatest number = " + result); 
            Console.ReadKey();
        }
    }
}

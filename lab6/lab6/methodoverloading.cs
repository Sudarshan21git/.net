using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class methodoverloading
    {
        public int add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int add(int a, int b)
        {
            return a + b;
        }
        public double add(double a, double b)
        {
            return a + b;
        }
    }
    internal class one
    {
        public static void Main(string[] args)
        {
            methodoverloading c = new methodoverloading();
            int x = c.add(1, 2, 3);
            int y = c.add(1, 2);
            double z = c.add(2.8, 3.5);
            Console.WriteLine("sum of two integers:" + x);
            Console.WriteLine("sum of three integers:" + y);
            Console.WriteLine("the sum of two float:" + z);
            Console.ReadKey();
        }
    }
}

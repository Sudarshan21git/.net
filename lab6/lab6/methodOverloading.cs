using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// to implement the concept of method overloading

namespace lab6
{
    public class methodOverloading
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double add(double a, double b)
        {
            return a + b;
        }
    }
    public class que1
    {
        static void Main()
        {
            methodOverloading m = new methodOverloading();
            Console.WriteLine("sum of 2 integer = " + m.add(1, 2));
            Console.WriteLine("sum of 3 integer = "+m.add(1,2,3));
            Console.WriteLine("sum of 2 double = "+m.add(1.2,2.2));
            Console.ReadKey();
        }
    }
}

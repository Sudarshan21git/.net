using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2_d
{
    interface Area {
        int findar();
    }
    interface Perimeter
    {
        int findperi();
    }
    class Square : Area, Perimeter
    {
        int l, b;
        public Square(int l, int b)
        {
            this.l = l;
            this.b = b;
        }
        public int findar()
        {
            return l * b;

        }
        public int findperi()
        {
            return 2* (l * b);

        }
    }

    public class MultipleInheritance
    {
        public static void Main(string[] args)
        {
            Square r = new Square(3,4);
            int a = r.findar();
            int p = r.findperi();
            Console.WriteLine($"Area is {a} and perimeter is {p}");
            Console.ReadKey();
        }
    }
}

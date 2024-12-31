using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// to implement concept of method overriding using virtual method
namespace lab6
{
    public class methodOverriding
    {
        public int a, b;
        public methodOverriding(int a, int b)
        {
            this.a = a; this.b = b;
        }

        public virtual int sum()
        {
            Console.WriteLine("Virtual method");
            return 0;
        }
    }
    public class addition : methodOverriding
    {
        public addition(int x, int y) : base(x, y)
        {
        }
        public override int sum()
        {
            return a + b;
        }
    }

    public class que2
    {
        static void Main()
        {
            addition a = new addition(1, 2);
            Console.WriteLine("Sum is "+a.sum());
            Console.ReadKey();
        }
    }
}

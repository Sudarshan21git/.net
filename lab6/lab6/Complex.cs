using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// to implement concept of following operator overloading
// (a) unary minus
namespace lab6
{
    public class Complex
    {
        public int real, img;
        public Complex(int real, int img)
        {
            this.real = real;
            this.img = img;
        }
        public void display()
        {
            Console.WriteLine( real + "+(" + img + "i)");
        }
        public static Complex operator -(Complex a)
        {
            return new Complex(-a.real, -a.img);
        }
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.real - b.real, a.img - b.img);
        }
    }
    public class que3_a{
        static void Main()
        {
            Complex c1 = new Complex(6, 2);
            Complex c2 = new Complex(2, 3);
            Console.WriteLine("Displaying 2 complex number:");
            c1.display();
            c2.display();

            Console.WriteLine("subtracting them:");
            Complex c3 = c1 - c2;
            c3.display();

            Console.WriteLine("Negative Complex number:");
            Complex c4 = -c3;
            c4.display();
            Console.ReadKey();
        }
    }
}

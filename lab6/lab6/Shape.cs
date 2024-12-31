using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Binary operator (* and /)
namespace lab6
{
    public class Shape
    {
        public double l, b;
        public Shape(double l, double b)
        {
            this.l = l;
            this.b = b;
        }
        public void display()
        {
            Console.WriteLine("Shape: " +l+ " l and " +b+ " b");
        }
        public static Shape operator *(Shape s1, Shape s2)
        {
            return new Shape(s1.l * s2.l, s1.b * s2.b);
        }
        public static Shape operator /(Shape s1, Shape s2)
        {
            return new Shape(s1.l / s2.l, s1.b / s2.b);
        }

    }
    public class que3_b
    {
        static void Main()
        {
            Shape x = new Shape(8, 5);
            Shape y = new Shape(4, 4);
            Console.WriteLine("Two shapes are : ");
            x.display();
            y.display();
            Console.WriteLine("multiplying them:");
            Shape z = x * y;
            z.display();
            Console.WriteLine("dividing them");
            Shape w = x / y;
            w.display();
            Console.ReadKey();

        }
        

    }
}

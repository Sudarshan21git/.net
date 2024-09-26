using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class Shape
    {
        public double dim1;
        public double dim2;
        public Shape(double dim1, double dim2)
        {
            this.dim1 = dim1;
            this.dim2 = dim2;
        }
        public virtual double Area()
        {
            Console.WriteLine("Undefined Shape");
            return 0;
        }

    }
    public class Triangle : Shape
    {
        public Triangle(double h, double b) : base(h, b) { }
        public override double Area()
        {
            return 0.5 * dim1 * dim2;
        }
    }
    internal class methodoveriding
    {

        public static void Main(string[] args)
        {
            Triangle t = new Triangle(5, 10);
            Console.WriteLine("Area of triangle is : " + t.Area());
            Console.ReadKey();

        }
    }
}

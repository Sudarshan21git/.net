using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{


    public abstract class shape
    {
      public double dim1 ,dim2 ;
        public shape(double dim1, double dim2)
        {
            this.dim1 = dim1;   
            this.dim2 = dim2;
        }
        public abstract double area();
    }
    public class Triangle : shape
    {
        public Triangle(double h, double b) : base(h, b)
        {
        }
        public override double area()
        {

            return (0.5 * dim1 * dim2);
        } 
    }
        internal class abstracts
        {
        public static void Main(String[] args)
        {
            Triangle t1 = new Triangle(6, 2);
            double a= t1.area();
            Console.WriteLine("area of traingle::" + a);
            Console.ReadKey();
        }
        }
    
  }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Mycricle
    {
        static void Main(string[] args)
        {
            circle c= new circle();
            c.setRadius(10);
            float a = c.findArea();
            float b = c.findcircumference();
            Console.WriteLine("the area of circle is:" + a);
            Console.WriteLine("the circumference  is:" + b);
            Console.Read();
        }
        public class circle
        {
            private float radius;
            public void setRadius(float r)
            {
                radius = r;
            }
            public float findArea()
            {
                return 3.14f * radius * radius;

                
            }
            public float findcircumference()
            {
                return 2 *3.14f*radius * radius;
            }

        }
    }

}

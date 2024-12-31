using System;


namespace ConsoleApp4
{
   
        public class Circle
        {
            private float radius;
            public Circle(float r)
            {
                radius = r;
            }
            public void area()
            {
                float ar = 3.14f * radius * radius;
                Console.WriteLine("Area is " + ar);
            }

            public void circumference()
            {
                float c = 2 * 3.14f * radius;
                Console.WriteLine("Circumference is " + c);
            }
        }
    public class Mycircle
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(7.5f);
            c1.area();
            c1.circumference();
        }
    }
   
}

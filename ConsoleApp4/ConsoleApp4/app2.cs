using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    
        public class Box
        {
            private float width, height, depth;
            public Box(float w, float h, float d)
            {
                width = w;
                height = h;
                depth = d;
            }
        public Box()
        {
            width = 1;
            height = 2;
            depth = 3;
        }
        public void volume()
            {
                float v = width*height*depth;
                Console.WriteLine("Volume is " + v);
            }

            public void surfaceArea()
            {
                float a = 2*(width*height+height*depth+depth*width);
                Console.WriteLine("Surface area is " + a);
            }
        }
        public class myBox
        {
            static void Main(string[] args)
            {
                Box b1 = new Box(2.3f, 3.5f, 4);
                b1.volume();
                b1.surfaceArea();
            Box b2 = new Box();
            b2.volume();
            b2.surfaceArea();
        }

        }
    
}

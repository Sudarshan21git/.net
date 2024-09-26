using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Q2
    {
        static void Main(string[] args)
        {
           box b = new box();
            box b1 = new box();
            b.setproperty(2,3,4);
            b1.setproperty(5, 6, 7);
            float a = b.volume();
            float c = b.findarea();
            float v = b1.volume();
            float d = b1.findarea();
            Console.WriteLine("the voulume of box is:" + a);
            Console.WriteLine("the area of box  is:" + c);
            Console.WriteLine("the voulume of box1 is:" + v);
            Console.WriteLine("the area of box1  is:" + d);
            Console.Read();
        }
        public class box
        {
            private int height, width, depth;
            public void setproperty(int h,int w,int d)
            {
                height = h; 
                width = w;
                depth = d;
            }
            public float volume()
            {
                return width * height * depth;


            }
            public float findarea()
            {
                return 2*(width*height+height*depth+depth*width);
            }

        }
    }

}

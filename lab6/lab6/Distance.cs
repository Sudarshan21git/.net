using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// relational operator (== and != )
namespace lab6
{
    public class Distance
    {
        public int m, cm;
        public Distance() { }
        public Distance(int m, int cm)
        {
            this.m = m;
            this.cm = cm;
        }
        public void display()
        {
            Console.WriteLine(m + " m " + cm + " cm");
        }
        public static bool operator ==(Distance d1, Distance d2){
            int cm1 = d1.m * 100 + d1.cm;
            int cm2 = d2.m *100 + d2.cm;
            if(cm1 == cm2)
                return true;
            else return false;
        }

        public static bool operator !=(Distance d1, Distance d2)
        {
            int cm1 = d1.m * 100 + d1.cm;
            int cm2 = d2.m*100 + d2.cm;
            if(cm1 != cm2)
                return true;
            else
            return false;
        }
    }

    public class que3_c
    {
        static void Main()
        {
            Distance d1 = new Distance(6,4);
            Distance d2 = new Distance(3,4);
            Console.WriteLine("two distances are : ");
            d1.display();
            d2.display();
            if (d1 == d2)
                Console.WriteLine("distances are equal");
            else Console.WriteLine("distance are not equal");
            Console.ReadKey();

        }
    }
}

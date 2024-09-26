using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Q3
    {
        public static void Main(string[] args)
        {
            Distance d1 = new Distance(7, 8);
            Distance d2 = new Distance(3, 6);
            Console.Write("Adding distance1:"); d1.displayDistance();
            Console.Write(" & distance2:"); d2.displayDistance();
            Distance res = d1.addDistance(d2);
            Console.WriteLine("the result is:");
            res.displayDistance();
            Console.ReadKey();
        }
        public class Distance
        {
            private int feet;
            private int inches;

            // Constructor
            public Distance(int feet, int inches)
            {
                this.feet = feet;
                this.inches = inches;
            }

            // Method to add distance
            public Distance addDistance(Distance other)
            {
                int totalInches = (this.feet + other.feet) * 12 + this.inches + other.inches;
                int feet = totalInches / 12;
                int inches = totalInches % 12;
                return new Distance(feet, inches);
            }

            // Method to display distance
            public void displayDistance()
            {
                Console.WriteLine("feet: " + feet + " inches: " + inches);
            }
        }

    }
}

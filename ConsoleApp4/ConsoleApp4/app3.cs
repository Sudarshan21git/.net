using System;

namespace ConsoleApp4
{
    
        public class Distance
        {
            private int feet, inches;

            public Distance(int f, int i)
            {
                feet = f;
                inches = i;
               
            }

            public void AddDistance(Distance o2)
            {
            if (inches >= 12)
            {
                feet += inches / 12;
                inches = inches % 12;
            }
            feet += o2.feet;
            inches += o2.inches;
               
            }
        public void subtractDistance(Distance o2)
        {
            
            feet -= o2.feet;
            inches -= o2.inches;
            if (feet<0)
            {
                Console.WriteLine("Distance cannot be in negative");
            }

        }

        public void DisplayDistance()
            {
                Console.WriteLine($"{feet} feet {inches} inches");
            }
        }
    public class MyDistance
        {
        static void Main(string[] args)
        {
                Distance d1 = new Distance(2, 12); 
                Distance d2 = new Distance(1, 3);  

                Console.Write("D1 = ");
                d1.DisplayDistance();
                Console.Write("D2 = ");
                d2.DisplayDistance();

                d1.AddDistance(d2);

                Console.Write("Resultant distance: ");
                d1.DisplayDistance();

            d1.subtractDistance(d2);
            Console.Write("Resultant distance: ");
            d1.DisplayDistance();

        }
    }
    
}

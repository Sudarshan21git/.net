using System;

namespace ConsoleApp4
{
    internal class app4
    {
        static class Sample
        {
          
            public static int Area(int l)
            {
                return l * l;
            }

            static Sample()
            {
                Console.WriteLine("Sample of static constructor.");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine($"The area using static class is {Sample.Area(4)}.");
        }
    }
}

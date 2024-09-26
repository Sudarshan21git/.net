using System;

namespace lab4
{
    static class Utility
    {
        // Static constructor
        static Utility()
        {
            Console.WriteLine("Static constructor called.");
        }

        // Static method
        public static void DisplayMessage()
        {
            Console.WriteLine("Hello from the .sudarshan  static class!");
        }
    }

    class Q4
    {
        static void Main(string[] args)
        {
            Utility.DisplayMessage();
            Console.ReadKey();  // Waits for a key press before closing the console
        }
    }
}

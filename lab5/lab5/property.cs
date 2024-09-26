using System;

namespace lab5
{
    public class People
    {
        private int roll;
        private string name;
        private string campus;

        public int Roll
        {
            set { roll = value; }
            get { return roll; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Campus
        {
            set { campus = value; }
            get { return campus; }
        }
    }

    internal class Property
    {
        public static void Main(string[] args)
        {
            People p1 = new People();
            p1.Roll = 1020;
            p1.Name = "Sudarshan";
            p1.Campus = "RR";

            Console.WriteLine("Student Roll: " + p1.Roll);
            Console.WriteLine("Student Name: " + p1.Name);
            Console.WriteLine("Student Campus: " + p1.Campus);
            Console.ReadKey();
        }
    }
}

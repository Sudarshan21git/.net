using System;
using System.Collections.Generic;
using System.Linq;

namespace lab8
{
    public class Student
    {
        public int id, roll;
        public string name, address, cname;
        public Student(int id, int roll, string name, string address, string cname)
        {
            this.id = id;
            this.roll = roll;
            this.name = name;
            this.address = address;
            this.cname = cname;
        }
    }
    internal class Q3
    {
        public static void Main(string[] args)
        {
            List<Student> slist = new List<Student>();
            slist.Add(new Student(01, 49, "Sudarshan", "ktm", "RR"));

            slist.Add(new Student(05, 40, "Rosn", "pkr", "baneshwor multiple campus"));
            slist.Add(new Student(07, 5, "Rajan", "kirtipur", "patan multiple campus"));
            slist.Add(new Student(08, 50, "Ujjwal", "ktm", "RR"));
            slist.Add(new Student(09, 21, "Sijan", "kirtipur", "patan multiple campus"));

            var result = slist.Where(stud => stud.address == "kirtipur" && stud.cname == "patan multiple campus");
            Console.WriteLine("Student info:");
            foreach (var s in result)
            {
                Console.WriteLine(s.id + " " + s.name + " " + s.address + " " + s.cname);
            }
            Console.ReadKey();
        }
    }
}

// write a c# program to create property and indexer.
using System;

namespace q3
{

    class Student
    {
        private string[] sub = new string[5];
        public string Name { get; set; }

        public string this[int index]
        {
            set
            {
                if (index >= 0 && index < sub.Length)
                {
                    sub[index] = value; 
                }
            }
            get
            {
                if (index >= 0 && index < sub.Length)
                {
                    return sub[index];
                }
                else
                {
                    return null;
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Student s = new Student(); 

            s.Name = "ritu";

            s[0] = "Networking";
            s[1] = "Dotnet Technology";
            s[2] = "MIS";
            s[3] = "Management";
            s[4] = "Computer Graphics";

            Console.WriteLine("Name: " + s.Name);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {s[i]}");
            }
            Console.ReadKey();
        }
    }
}

/*
Example of indexer

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class IndexerClass
    {
        private string[] sub = new string[5];
        public string this[int i]
        {
            get
            {
                return sub[i];
            }
            set
            {
                sub[i] = value;
            }
        }
    }
    internal class q3
    {
        public static void Main(string[] args)
        {
            IndexerClass subject = new IndexerClass();
            subject[0] = "MSI and E-Business";
            subject[1] = "Introductio to Management";
            subject[2] = "Computer Graphics and Animation";
            subject[3] = "DotNet";
            subject[4] = "Networking";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(subject[i]);
            }
            Console.ReadKey();
        }
    }
}
*/
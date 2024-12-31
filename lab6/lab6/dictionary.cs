using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class dictionary
    {
        public static void Main()
        {
            Dictionary<string, string> dt = new Dictionary<string, string>();
            dt.Add("name", "ritu");
            dt.Add("roll", "36");
            dt.Add("subject", "dotnet");
            dt.Remove("roll");

            Console.WriteLine("Dictionary items are:");
            foreach (KeyValuePair<string, string> kvp in dt)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            Console.ReadKey();
        }
    }
}

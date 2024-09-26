using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Indexerclass
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
    internal class indexEx2
    {
        public static void Main(string[] args)
        {

            Indexerclass subject = new Indexerclass();
            subject[0] = "DOT Net";
            subject[1] = "Python";
            subject[2] = "Networking";
            subject[3] = "Java";
            subject[4] = "Math";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(subject[i]);
            }
            Console.ReadKey();

        }

    }
}
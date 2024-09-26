

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Lab8
{
    internal class insert
    {
        public static void Main(string[] args)
        {

            MySqlConnection conn = new MySqlConnection("server=localhost; database=bank; uid=root; password='';");
            conn.Open();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Account number: ");
                double ac = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name : ");
                string nm = Console.ReadLine();
                Console.WriteLine("Enter Address : ");
                string ad = Console.ReadLine();
                Console.WriteLine("Enter Salary : ");
                double sl = double.Parse(Console.ReadLine());


                string sql = ($"insert into customer  values ('{ac}','{nm}','{ad}',{sl})");
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    Console.WriteLine("Data is inserted.");
                }
                else
                {
                    Console.WriteLine("Error iserting data.");
                }
            }



            conn.Close();
            Console.ReadKey();
        }
    }
}
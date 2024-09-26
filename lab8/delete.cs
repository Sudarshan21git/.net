using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace lab8
{
    internal class delete
    {
        public static void Main(string[] args)
        {

            MySqlConnection conn = new MySqlConnection("server=localhost; database=bank; uid=root; password='';");
            conn.Open();
            for (int i = 0; i < 3; i++)
            {
                string sql2 = "delete from customer where deposit<500";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                int row2 = cmd2.ExecuteNonQuery();
                if (row2 > 0)
                    Console.WriteLine(row2 + " row deleted.");
                else
                    Console.WriteLine("deletion failed");

                conn.Close();
                Console.ReadKey();
            }
        }
    }
}

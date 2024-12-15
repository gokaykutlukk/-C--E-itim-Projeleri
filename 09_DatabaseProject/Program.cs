using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ado:net

            Console.WriteLine("***** C# Veri tabanlı Ürün kategori Bilgi Sistemi ****");
            Console.WriteLine();
            Console.WriteLine();


            string tableNumber;

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1-Kategoryler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-siperaişler");
            Console.WriteLine("4-Çıkış yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");

            tableNumber = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=GOKAY\\SQLEXPRESS;initial Catalog=EğitimKampiDb; integrated security=true ");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);//dataadapter köprü görevi görüyor
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable); //buda bellekte 

            foreach (DataRow row in dataTable.Rows)
            {
               foreach (var item in row.ItemArray) 
                {
                    Console.Write(item.ToString());
                }
               Console.WriteLine();
            }

            connection.Close();



            Console.Read();
        }
    }
}

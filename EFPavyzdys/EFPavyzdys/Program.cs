using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPavyzdys
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GautiViska();
        }

        private static void GautiViska()
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C_20191212KursaiVakariniai\EFPavyzdys\EFPavyzdys\DuomenuBaze.mdf;Integrated Security=True";
            DataContext db = new DataContext(ConnectionString);
            var table = db.GetTable<User>();

            foreach (var item in table)
            {
                Console.WriteLine(item.Vardas);
                foreach (var kreps in item.Krepselis)
                {
                    Console.WriteLine(kreps.Busena);

                    foreach (var prek in kreps.Prekes)
                    {
                        Console.WriteLine(prek.Pavadinimas);
                        Console.WriteLine(prek.Kaina);
                    }
                }
            }
        }
    }
}
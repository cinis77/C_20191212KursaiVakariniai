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
        private static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C_20191212KursaiVakariniai\EFPavyzdys\EFPavyzdys\DuomenuBaze.mdf;Integrated Security=True";

        private static void Main(string[] args)
        {
            // DaromIrasa();
            //Atnaujinimas();
            Istrinti();
            GautiViska();
        }

        private static void DaromIrasa()
        {
            User useris = new User();
            useris.Vardas = "Antanas";
            Krepseli kreps = new Krepseli();
            kreps.Busena = "";
            useris.Krepselis.Add(kreps);
            Preke preke = new Preke()
            {
                Kaina = 10,
                Svoris = 5,
                Pavadinimas = "kazkas"
            };
            kreps.Prekes.Add(preke);
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C_20191212KursaiVakariniai\EFPavyzdys\EFPavyzdys\DuomenuBaze.mdf;Integrated Security=True";

            DataContext db = new DataContext(ConnectionString);
            db.GetTable<User>().InsertOnSubmit(useris);
            db.SubmitChanges();
        }

        private static void Istrinti()
        {
            DataContext db = new DataContext(ConnectionString);
            var table = db.GetTable<User>().Where(x => x.Vardas == "Antanas").First();
            db.GetTable<User>().DeleteOnSubmit(table);
            db.SubmitChanges();
        }

        private static void Atnaujinimas()
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C_20191212KursaiVakariniai\EFPavyzdys\EFPavyzdys\DuomenuBaze.mdf;Integrated Security=True";

            DataContext db = new DataContext(ConnectionString);
            var table = db.GetTable<Krepseli>().Where(x => x.VartotojoID == 1);
            foreach (var item in table)
            {
                item.VartotojoID = 2;
                int bandom = item.VartotojoID == null ? 0 : (int)item.VartotojoID;
            }

            db.SubmitChanges();
        }

        private static void GautiViska()
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C_20191212KursaiVakariniai\EFPavyzdys\EFPavyzdys\DuomenuBaze.mdf;Integrated Security=True";
            DataContext db = new DataContext(ConnectionString);
            var table = db.GetTable<User>().Where(x => x.Vardas == "Jonas")
                .OrderByDescending(x => x.Vardas)
                .ThenBy(x => x.Id).ToList();

            foreach (var item in table)
            {
                Console.WriteLine(item.Vardas);

                foreach (var kreps in item.Krepselis.Where(x => string.IsNullOrEmpty(x.Busena)))
                {
                    Console.WriteLine(kreps.Busena);
                    Console.WriteLine("Max kaina krepselyje " + kreps.Prekes.Max(x => x.Kaina));
                    foreach (var prek in kreps.Prekes)
                    {
                        Console.WriteLine(prek.Pavadinimas);
                        Console.WriteLine(prek.Kaina);
                        List<int> a = new List<int>();
                    }
                }
            }
        }
    }
}
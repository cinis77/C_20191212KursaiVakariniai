using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace Biblioteka
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            try
            {
                MessageBox.Show("Pasirinkite skaitytoju faila");
                string skaitytojaiPath = null;
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        skaitytojaiPath = ofd.FileName;
                    }
                }
                if (skaitytojaiPath == null)
                {
                    throw new Exception("Nepasirinktas skaitytojo kelias");
                }
                MessageBox.Show("Pasirinkite knygu faila");
                string knygosPath = null;
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        knygosPath = ofd.FileName;
                    }
                }
                ParseData(skaitytojaiPath, knygosPath);
            }
            catch (ArgumentNullException ex)
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ParseData(string skaitytojai, string knygos)
        {
            Dictionary<int, Skaitytojai> visiSkaitytojai = new Dictionary<int, Skaitytojai>();
            using (System.IO.StreamReader reader = new System.IO.StreamReader(skaitytojai))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    var data = line.Split(';');
                    Skaitytojai skaitytojas = new Skaitytojai();
                    skaitytojas.Vardas = data[0];
                    skaitytojas.Pavarde = data[1];
                    skaitytojas.ID = int.Parse(data[2]);
                    visiSkaitytojai.Add(skaitytojas.ID, skaitytojas);
                }
            }

            using (System.IO.StreamReader reader = new System.IO.StreamReader(knygos))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    var data = line.Split(';');
                    Knyga knyga = new Knyga();
                    knyga.ID = int.Parse(data[0]);
                    knyga.Pavadinimas = data[1];
                    knyga.Autorius = data[2];
                    knyga.Zanras = data[3];
                    knyga.PaėmimoData = DateTime.Parse(data[4]);
                    knyga.GražinimoData = DateTime.Parse(data[5]);
                    knyga.VartotojoID = int.Parse(data[6]);

                    visiSkaitytojai[knyga.VartotojoID].PasiimtosKnygos.Add(knyga);
                }

                InformacijosPaieska(visiSkaitytojai);
            }
        }

        private static void InformacijosPaieska(Dictionary<int, Skaitytojai> skaitytojai)
        {
            foreach (var item in skaitytojai)
            {
                Console.WriteLine(item.Value.Vardas + " " + item.Value.Pavarde
                    + " turi pasiemes " + item.Value.PasiimtosKnygos.Count);
                foreach (var knyga in item.Value.PasiimtosKnygos)
                {
                    if ((DateTime.Today - knyga.GražinimoData).TotalDays > 0)
                    {
                        Console.WriteLine("Reikia grazinti knyga " + knyga.Pavadinimas);
                    }
                }
            }
        }
    }
}
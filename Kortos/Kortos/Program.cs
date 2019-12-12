using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortos
{
    internal class Korta
    {
        public int Reikšmė { get; }
        public string Rušis { get; }

        public string Skaicius { get; }

        /// <summary>
        /// Sukuriama korta
        /// </summary>
        /// <param name="Reikšmė">Reiksme nuo 1 - 13</param>
        /// <param name="Rušis">Galima rusis K, S, B, V</param>
        public Korta(int Reikšmė, string Rušis)
        {
            this.Reikšmė = Reikšmė;
            this.Rušis = Rušis;
            Skaicius = Transformacija();
        }

        private string Transformacija()
        {
            if (Reikšmė == 1)
            {
                return "A";
            }
            else if (Reikšmė == 11)
            {
                return "J";
            }
            else if (Reikšmė == 12)
            {
                return "Q";
            }
            else if (Reikšmė == 13)
            {
                return "K";
            }
            else
            {
                return Reikšmė.ToString();
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rng = new Random();
            List<Korta> kalade = new List<Korta>();
            char[] reiksmes = { 'K', 'D', 'S', 'V' };
            int i = 0;
            while (i < 52)
            {
                Korta korta = new Korta(rng.Next(1, 14), reiksmes[rng.Next(0, reiksmes.Length)].ToString());
                bool JauYra = false;
                foreach (var item in kalade)
                {
                    if (item.Reikšmė == korta.Reikšmė && item.Rušis == korta.Rušis)
                    {
                        JauYra = true;
                        break;
                    }
                }
                if (!JauYra)
                {
                    kalade.Add(korta);
                    i++;
                }
            }
            foreach (var kor in kalade)
            {
                Console.WriteLine(kor.Skaicius + " " + kor.Rušis);
            }
        }
    }
}
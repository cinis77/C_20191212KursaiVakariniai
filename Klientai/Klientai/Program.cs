using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klientai
{
    internal class Vartotojas
    {
        public string Vardas { get; set; }
        public int ID { get; set; }

        public virtual double Mokėti(double suma)
        {
            return suma;
        }
    }

    internal class VIP : Vartotojas
    {
        public override double Mokėti(double suma)
        {
            return base.Mokėti(suma) * 0.7;
        }
    }

    internal class Silver : Vartotojas
    {
        public override double Mokėti(double suma)
        {
            return base.Mokėti(suma) * 0.9;
        }
    }

    internal class Basic : Vartotojas
    {
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Vartotojas> vartotojai = new List<Vartotojas>
            {
                new VIP(),
                new Silver(),
                new Basic()
            };

            foreach (var item in vartotojai)
            {
                Console.WriteLine(item.Mokėti(10));
            }
        }
    }
}
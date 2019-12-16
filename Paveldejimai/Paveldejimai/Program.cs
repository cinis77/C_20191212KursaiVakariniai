using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldejimai
{
    internal class TransportoPriemone
    {
        public int Galia
        {
            get;
            set;
        }

        public int KeleiviuSkaicius { get; set; }
        public double Svoris { get; set; }
        public double Greitis { get; set; }

        private string _Gamintojas;

        public string Gamintojas
        {
            get
            {
                return _Gamintojas;
            }
            set
            {
                if (value != _Gamintojas)
                {
                    _Gamintojas = value;
                    Drive();
                }
            }
        }

        public virtual void Drive()
        {
            Console.WriteLine("Vaziuoju");
        }

        public void Sustoti()
        {
            Console.WriteLine("Sustoju");
        }

        public TransportoPriemone(int keleiviuSk, double greitis)
        {
            KeleiviuSkaicius = keleiviuSk;
            Greitis = greitis;
        }
    }

    internal class Automobilis : TransportoPriemone
    {
        public int Rida { get; set; }

        public Automobilis(int keleivius, double gr) : base(keleiviuSk: keleivius, greitis: gr)
        {
            DateTime date = new DateTime(day: 15, year: 2010, month: 6);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<TransportoPriemone> transportas = new List<TransportoPriemone>();
            transportas.Add(new Lektuvas(120, 3500));
            transportas.Add(new Automobilis(5, 180));
            TransportoPriemone trans = new Lektuvas(100, 3600);
            transportas[0].Drive();

            Lektuvas lek = (Lektuvas)trans;

            object objektas = lek;
            ((Lektuvas)objektas).Skristi();
            object ob = 10;
        }
    }
}
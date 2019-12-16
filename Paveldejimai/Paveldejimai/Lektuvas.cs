using System;

namespace Paveldejimai
{
    internal class Lektuvas : TransportoPriemone
    {
        public int MotoruSkaicius { get; set; }
        public double SparnuIlgis { get; set; }

        public Lektuvas(int keleiviuSk, double greitis) : base(keleiviuSk, greitis)
        {
        }

        public void Skristi()
        {
            Console.WriteLine("Skrendu");
            Console.WriteLine(Galia);
            Console.WriteLine(KeleiviuSkaicius);

            base.Svoris = 100;

            this.Skristi();
        }

        public override void Drive()
        {
            Console.WriteLine("Vaziuoju i kylimo taka");
        }
    }
}
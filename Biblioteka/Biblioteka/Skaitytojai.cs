using System.Collections.Generic;

namespace Biblioteka
{
    internal class Skaitytojai
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int ID { get; set; }
        public readonly List<Knyga> PasiimtosKnygos;

        public Skaitytojai()
        {
            PasiimtosKnygos = new List<Knyga>();
        }
    }
}
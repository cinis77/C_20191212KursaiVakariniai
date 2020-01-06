using System;

namespace Biblioteka
{
    internal class Knyga
    {
        public int ID { get; set; }
        public string Pavadinimas { get; set; }
        public string Autorius { get; set; }
        public string Zanras { get; set; }

        public DateTime PaėmimoData { get; set; }
        public DateTime GražinimoData { get; set; }

        private bool KnygaPaimta = false;
    }
}
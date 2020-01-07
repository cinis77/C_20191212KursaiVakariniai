using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoldunuValgymoCempionatas
{
    internal class BlogaException : Exception
    {
        public BlogaException(string zaidejoVardas)
        {
            Console.WriteLine("Pasidare bloga" + zaidejoVardas);
        }
    }

    internal class Zaidejai
    {
        public int valgmoGreiti { get; set; }
        public int SkrandzioTuris { get; set; }
        public string Vardas { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}
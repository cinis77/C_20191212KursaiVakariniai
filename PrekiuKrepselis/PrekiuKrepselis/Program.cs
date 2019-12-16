using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrekiuKrepselis
{
    internal class Preke
    {
    }

    internal class Siunta
    {
    }

    internal class PrekiuKrepselis
    {
        public readonly List<Preke> Prekes;

        public Siunta Siuntinys { get; }

        public PrekiuKrepselis()
        {
            Prekes = new List<Preke>();
            Siuntinys = new Siunta();
        }

        private void Test()
        {
            Prekes = new List<Preke>();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> A = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine(A.Count);

            List<int> B = new List<int>();
            B = A;
            Console.WriteLine(B.Count);
            A.Clear();
            Console.WriteLine(B.Count);
        }
    }
}
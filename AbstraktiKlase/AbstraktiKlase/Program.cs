using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraktiKlase
{
    internal abstract class Figura
    {
        public int A { get; set; }

        public abstract double Plotas(int a);

        public void Method()
        {
        }
    }

    internal class Trikampis : Figura
    {
        public override double Plotas(int a)
        {
            int b = 2;
            Console.WriteLine(a * b / 2);
            return 0;
        }
    }

    internal class Kvadratas : Figura
    {
        public override void Plotas()
        {
            int a = 2;
            Console.WriteLine(a * a);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Figura> figuros = new List<Figura>()
            {
                new Trikampis(),
                new Kvadratas()
            };
        }
    }
}
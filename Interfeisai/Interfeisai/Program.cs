using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfeisai
{
    internal interface ITestasInterface
    {
        int VienasProperty { get; set; }
        string AntrasProperty { get; set; }

        void MetodasVienas();

        int MetodasDu(int a);
    }

    internal interface IAntrasInterface
    {
        void AntroInterfaceMetodas();
    }

    internal class PanaudojaInterface : ITestasInterface, IAntrasInterface
    {
        public int VienasProperty { get; set; }

        public string AntrasProperty { get; set; }

        public void AntroInterfaceMetodas()
        {
        }

        public void MetodasVienas()
        {
        }

        public int MetodasDu(int a)
        {
            return 0;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            PanaudojaInterface panaudoja = new PanaudojaInterface();

            ITestasInterface testas = panaudoja;
            IAntrasInterface testas2 = panaudoja;
            ITestasInterface testasCtor = new PanaudojaInterface() { VienasProperty = 1 };
            testasCtor.MetodasDu(2);

            List<ITestasInterface> sarasas = new List<ITestasInterface>();
            IList<ITestasInterface> testasInterfaces = new List<ITestasInterface>();
        }
    }
}
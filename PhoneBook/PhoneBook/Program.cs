using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite telefona ir vardas atskirant kableliu");
            var data = Console.ReadLine();
            var splitData = data.Split(',');
            long telefonas = 0;
            Dictionary<string, long> telefonuKnyga = new Dictionary<string, long>();

            if (long.TryParse(splitData.First(), out telefonas))
            {
                telefonuKnyga.Add(splitData.Last(), telefonas);
            }
            else
            {
                Console.WriteLine("Neteisingai iveste telefono reiksme");
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;

namespace PavyzdysTestavimasTCPIP
{
    public class DataPrep
    {
        private IClient _Client;
        private IDataPArser Parser;

        public DataPrep(IClient client, IDataPArser pArser)
        {
            _Client = client;
            Parser = pArser;
        }

        public bool SendPrepData(string data)
        {
            string prepData = @"$" + data + @"$";
            _Client.Send(prepData);
            //Laukti kol gausit atsakyma?????
            ParseReceivedData();
            return true;
        }

        public void ParseReceivedData()
        {
            Parser.ParseData();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}
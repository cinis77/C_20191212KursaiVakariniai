using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace XMLKlases
{
    public class ManoKlase
    {
        public int Pirmas { get; set; }
        public string Antras { get; set; }

        [XmlArray]
        public List<DaugElementu> Elementai;
    }

    public class DaugElementu
    {
        public int AAA { get; set; }
        public int BBB { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            XmlSerializer xml = new XmlSerializer(typeof(ManoKlase));
            using (XmlReader reader = XmlReader.Create("machine.KCS"))
            {
                ManoKlase iten = (ManoKlase)xml.Deserialize(reader);
                Console.WriteLine(iten.Antras + " " + iten.Pirmas);
            }
        }

        private static void SukurtiXML()
        {
            XmlSerializer xml = new XmlSerializer(typeof(ManoKlase));

            using (System.IO.FileStream stream = System.IO.File.Create(@"machine.KCS"))
            {
                ManoKlase objektas = new ManoKlase()
                {
                    Pirmas = 10,
                    Antras = "Laba Diena"
                };

                xml.Serialize(stream, objektas);
            }
        }
    }
}
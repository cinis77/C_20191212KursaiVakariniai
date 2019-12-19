using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PavyzdysTestavimasTCPIP;

namespace DataPrep.UnitTest
{
    [TestClass]
    public class DataPrepUnitTest
    {
        [TestMethod]
        public void DataPrepKonstuktoriu_BandysimSusikonsturotiObjekta_KlaidosNegauti()
        {
            PavyzdysTestavimasTCPIP.DataPrep dataPrep =
                new PavyzdysTestavimasTCPIP.DataPrep(new FakeClient()

                , new FakeDataParser());

            Assert.IsTrue(true);
        }
    }

    internal class FakeClient : IClient
    {
        public string IP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Port { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public string Read()
        {
            throw new NotImplementedException();
        }

        public void Send(string dataToSend)
        {
            throw new NotImplementedException();
        }
    }

    internal class FakeDataParser : IDataPArser
    {
        public void ParseData()
        {
            ;
        }
    }
}
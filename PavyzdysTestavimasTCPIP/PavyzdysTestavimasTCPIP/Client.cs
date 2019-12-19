using System;
using System.Net.Sockets;

namespace PavyzdysTestavimasTCPIP
{
    public interface IClient
    {
        string IP { get; set; }
        int Port { get; set; }

        void Send(string dataToSend);

        string Read();

        void Connect();

        void Disconnect();
    }

    public class Client : IClient
    {
        public string IP { get; set; }

        public int Port { get; set; }

        private TcpClient _Client;

        public Client(string ip, int port)
        {
            IP = ip;
            Port = port;

            _Client = new TcpClient(IP, Port);
        }

        public void Send(string dataToSend)
        {
            Console.WriteLine("Siunciu duomenis");
            var stream = _Client.GetStream();
        }

        public string Read()
        {
            Console.WriteLine("Skaitau duomenis");
            return string.Empty;
        }

        public void Connect()
        {
            _Client.Connect("", Port);
        }

        public void Disconnect()
        {
            _Client.Close();
        }
    }
}
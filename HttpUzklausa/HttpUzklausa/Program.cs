using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace HttpUzklausa
{
    internal class Token
    {
        public string token { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            GautiHttpUzklausa();
            while (true)
            {
            }
        }

        private static async void GautiHttpUzklausa()
        {
            HttpClient client = new HttpClient();
            Dictionary<string, string> _content = new Dictionary<string, string>();
            _content.Add("username", "tesonet");
            _content.Add("password", "partyanimal");
            var content = new FormUrlEncodedContent(_content);
            var response = await client.PostAsync("http://playground.tesonet.lt/v1/tokens", content);
            var gautasTextas = await response.Content.ReadAsStringAsync();
            Console.WriteLine(gautasTextas);
            Token token = Newtonsoft.Json.JsonConvert.DeserializeObject<Token>(gautasTextas);
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.token);
            var resp = await client.GetAsync("http://playground.tesonet.lt/v1/servers");
            var gt = await resp.Content.ReadAsStringAsync();
            Console.WriteLine(gt);
        }
    }
}
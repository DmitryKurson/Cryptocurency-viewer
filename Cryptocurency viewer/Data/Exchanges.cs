using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace Cryptocurency_viewer.Data
{
    class Exchanges
    {
        public string exchange_id { get; set; }
        public string name { get; set; }
        public string website { get; set; }
        public string volume_24h { get; set; }

        public static Exchanges[] GetExchanges()
        {          
            var client = new RestClient("https://cryptingup.com/api/");
            var request = new RestRequest("exchanges");
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;
                Rootobject result = JsonConvert.DeserializeObject<Rootobject>(rawResponse);

                return result.exchanges;
            }
            else
            {
                return null;
            }
        }

        public class Rootobject
        {
            public Exchanges[] exchanges { get; set; }
        }
    }
}

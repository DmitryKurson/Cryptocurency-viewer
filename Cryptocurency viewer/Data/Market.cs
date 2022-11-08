using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace Cryptocurency_viewer.Data
{
    public class Market
    {
        public string exchange_id { get; set; }
        public string symbol { get; set; }
        public string base_asset { get; set; }
        public string quote_asset { get; set; }
        public string price_unconverted { get; set; }
        public string price { get; set; }
        public string change_24h { get; set; }
        public string spread { get; set; }
        public string volume_24h { get; set; }
        public string status { get; set; }       
        public string created_at { get; set; }
        public string updated_at { get; set; }

        public static Market[] GetMarket()
        {
            var client = new RestClient("https://cryptingup.com/api/");
            var request = new RestRequest("markets");
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;
                Rootobject result = JsonConvert.DeserializeObject<Rootobject>(rawResponse);
                return result.markets;
            }
            else
            {
                return null;
            }
        }
    }
}

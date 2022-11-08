using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace Cryptocurency_viewer.Data
{
    public class Assets
    {
        public string asset_id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string volume_24h { get; set; }
        public string change_1h { get; set; }
        public string change_24h { get; set; }
        public string change_7d { get; set; }
        public string status { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }


        public static Assets[] GetAssets()
        {
            var client = new RestClient("https://cryptingup.com/api/");
            var request = new RestRequest("assets");
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;
                Rootobject result = JsonConvert.DeserializeObject<Rootobject>(rawResponse);

                return result.assets;
            }
            else
            {
                return null;
            }
        }
    }
}

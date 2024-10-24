using Armazenamento;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Consumindo
{
    internal class Api
    {
        public Geral.Welcome Consumir(string year)
        {
            RestClient client = new RestClient("https://datausa.io/");
            RestRequest request = new RestRequest("api/data", Method.Get);
            request.AddParameter("drilldowns", "Nation");
            request.AddParameter("measures", "Population");
            request.AddParameter("Year",year);

            RestResponse response = client.Execute(request);

            Geral.Welcome infos = JsonConvert.DeserializeObject<Geral.Welcome>(response.Content);

            return infos;
        }
    }
}

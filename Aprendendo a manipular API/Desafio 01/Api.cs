using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace Desafio_01
{
    internal class Api
    {
        public async Task<Country> ConsultarFronteiras(string name)
        {
            var client = new RestClient("https://restcountries.com/v3.1");
            var request = new RestRequest($"/translation/{name}", Method.Get);

            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                var countries = JsonConvert.DeserializeObject<List<Country>>(response.Content);
                return countries[0];
            }
            else
            {
                throw new Exception("Erro ao obter dados: " + response.ErrorMessage);
            }
        }

        public async Task<Country> Fronteira(string sigla)
        {
            var client = new RestClient("https://restcountries.com/v3.1");
            var request = new RestRequest($"/alpha/{sigla}", Method.Get);

            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {

                var countries = JsonConvert.DeserializeObject<List<Country>>(response.Content);
                return countries[0];
            }
            else
            {
                throw new Exception("Erro ao obter dados: " + response.ErrorMessage);
            }
        }
    }
}

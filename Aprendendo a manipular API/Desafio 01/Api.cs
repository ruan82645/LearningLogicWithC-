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
        public async Task<List<Country>> ConsultarFronteiras(string name)
        {
            var client = new RestClient("https://restcountries.com/v3.1");
            var request = new RestRequest($"/name/{name}", Method.Get);

            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                Console.WriteLine("Resposta da API: " + response.Content); // Adicione esta linha
                var countries = JsonConvert.DeserializeObject<List<Country>>(response.Content);
                return countries;
            }
            else
            {
                throw new Exception("Erro ao obter dados: " + response.ErrorMessage);
            }
        }

        public async Task<List<Country>> Fronteira(string sigla)
        {
            var client = new RestClient("https://restcountries.com/v3.1");
            var request = new RestRequest($"/alpha/{sigla}", Method.Get);

            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {

                var countries = JsonConvert.DeserializeObject<List<Country>>(response.Content);
                return countries;
            }
            else
            {
                throw new Exception("Erro ao obter dados: " + response.ErrorMessage);
            }
        }
    }
}

using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_05
{
    internal class Api
    {
        public async Task<Infos> Request()
        {
            var client = new RestClient("https://api.coinbase.com/v2/currencies");
            var request = new RestRequest("", Method.Get);

            try
            {
                RestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    Infos infos = JsonConvert.DeserializeObject<Infos>(response.Content);
                    return infos;
                }
                else
                {
                    Console.WriteLine($"Erro: {response.StatusCode} - {response.ErrorMessage}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exceção: {ex.Message}");
                return null; 
            }
        }
    }
}

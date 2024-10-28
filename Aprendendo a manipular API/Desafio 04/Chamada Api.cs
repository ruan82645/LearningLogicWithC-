using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft;
using Newtonsoft.Json;

namespace Desafio_04
{
    internal class Api
    {
        public async Task<string> getIp()
        {
            try
            {
                RestClient client = new RestClient("https://api.ipify.org/?format=json");
                RestRequest request = new RestRequest("", Method.Get);
                RestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    Info ip = JsonConvert.DeserializeObject<Info>(response.Content);
                    return ip.ip;
                }
                else
                {
                   
                    return $"Erro: Não foi possível obter o IP. Status: {response.StatusCode}";
                }
            }
            catch (JsonException jsonEx)
            {
                return $"Erro ao deserializar a resposta: {jsonEx.Message}";
            }
            catch (Exception ex)
            {
                return $"Ocorreu um erro: {ex.Message}";
            }
        }
    }
}

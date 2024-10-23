using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneroPorNome
{
    internal class GeneroPorNome
    {
        public class GenderApiResponse
        {
            public string gender { get; set; }

        }

        public class ApiGenderize
        {
            public async Task<string> GetGenderAsync(string nome)
            {

                RestClient client = new RestClient("https://api.genderize.io");

                RestRequest request = new RestRequest("", Method.Get);
                request.AddParameter("name", nome);

                RestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {

                    GenderApiResponse resultado = JsonConvert.DeserializeObject<GenderApiResponse>(response.Content);

                    return resultado.gender;
                }
                else
                {
                    return $"Falha ao obter resposta da API: {response.StatusDescription}";
                }
            }
        }

    }
}

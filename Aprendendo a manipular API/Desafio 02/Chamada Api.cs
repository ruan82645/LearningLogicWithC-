using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace Desafio_02
{
    public class Api
    {
        public async Task<List<Repositorios>> Verificar(string usuario)
        {   
            RestClient client = new RestClient("https://api.github.com/");
            RestRequest request = new RestRequest($"users/{usuario}/repos", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                var repositorio = JsonConvert.DeserializeObject<List<Repositorios>>(response.Content);
                return repositorio;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

    }
    
}

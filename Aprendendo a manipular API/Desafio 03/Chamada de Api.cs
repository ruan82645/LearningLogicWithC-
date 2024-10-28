using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_03
{
    internal class Chamada_de_Api
    {
        public async Task<List<Infos>> filmes(int pagina)
        {

            RestClient client = new RestClient("https://api.themoviedb.org/3/");
            client.AddDefaultHeader("api_Key", "c634b4775a037a56f5dd2baf3951c4e8");
            var request = new RestRequest($"movie/popular?api_key=c634b4775a037a56f5dd2baf3951c4e8&page={pagina}", Method.Get);

            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                var popularMovies = JsonConvert.DeserializeObject<List<Infos>>(response.Content);
                return popularMovies;
            }
            else
            {
                throw new Exception("Erro ao obter dados da API: " + response.ErrorMessage);
            }
        }
    }

}


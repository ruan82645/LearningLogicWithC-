using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumindo_Api_pelo_Rest_Sharp
{
    public class dados
    {
        public int age { get; set; }
        public int count { get; set; }
        public string name { get; set; }
    }

    public class Solicitando
    {
        public int solicitar(string nome)
        {
            string apiUrl = "https://api.agify.io";

            RestClient client = new RestClient(apiUrl);

            // Criando a requisição GET
            RestRequest request = new RestRequest("?name=" + nome, Method.Get);

            // Executando a requisição
            RestResponse response = client.Execute(request);

            dados convertido = new dados();

            if (response.IsSuccessful)
            {

                convertido = JsonConvert.DeserializeObject<dados>(response.Content);
            }
            else
            {
                Console.WriteLine($"Erro: {response.StatusCode}");
            }
            

            return convertido.age  ; 
        }
    }
}

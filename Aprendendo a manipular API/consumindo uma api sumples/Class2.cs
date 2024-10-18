using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumindo_uma_api_sumples
{
    internal class Leitura
    {
        public Endereco ConsultaCep(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";

            string endereco = new System.Net.WebClient().DownloadString(url);

            return JsonConvert.DeserializeObject<Endereco>(endereco);

        }
    }
}

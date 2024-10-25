using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using RestSharp;

namespace Desafio_02
{
        public class Repositorios
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("language")]
            public string Language { get; set; }

            [JsonProperty("stargazers_count")]
            public int Starsgazers_count { get; set; }

            [JsonProperty("forks_count")]
            public int Forks_count { get; set; }
        }
}


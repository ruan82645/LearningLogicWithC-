using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using RestSharp;

namespace Desafio_01
{
    public partial class Country
    {
        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("cca3")]
        public string Cca3 { get; set; }

        [JsonProperty("languages")]
        public Dictionary<string, string> languages { get; set; }

        [JsonProperty("translations")]
        public Dictionary<string, Translation> Translations { get; set; }

        [JsonProperty("borders")]
        public string[] Borders { get; set; }

        [JsonProperty("population")]
        public long Population { get; set; }
    }



    public partial class Name
    {
        [JsonProperty("common")]
        public string Common { get; set; }

        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("nativeName")]
        public NativeName NativeName { get; set; }
    }

    public partial class NativeName
    {
        [JsonProperty("por")]
        public Translation Por { get; set; }
    }

    public partial class Translation
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }
}




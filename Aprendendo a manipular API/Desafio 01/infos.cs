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
        public languages languages { get; set; }

        [JsonProperty("translations")]
        public Dictionary<string, Translation> Translations { get; set; }

        [JsonProperty("borders")]
        public string[] Borders { get; set; }

        [JsonProperty("population")]
        public long Population { get; set; }
    }

    public partial class languages
    {
            [JsonProperty("fra")]
            public string Fra { get; set; }

            [JsonProperty("gsw")]
            public string Gsw { get; set; }

            [JsonProperty("ita")]
            public string Ita { get; set; }

            [JsonProperty("roh")]
            public string Roh { get; set; }

            [JsonProperty("por")]
            public string Por { get; set; }

            [JsonProperty("eng")]
            public string Eng { get; set; }

            [JsonProperty("spa")]
            public string Spa { get; set; }

            [JsonProperty("ger")]
            public string Ger { get; set; }

            [JsonProperty("rus")]
            public string Rus { get; set; }

            [JsonProperty("jpn")]
            public string Jpn { get; set; }

            [JsonProperty("kor")]
            public string Kor { get; set; }

            [JsonProperty("zho")]
            public string Zho { get; set; }

            [JsonProperty("ara")]
            public string Ara { get; set; }

            [JsonProperty("hin")]
            public string Hin { get; set; }

            [JsonProperty("ben")]
            public string Ben { get; set; }

            [JsonProperty("urd")]
            public string Urd { get; set; }

            [JsonProperty("tur")]
            public string Tur { get; set; }

            [JsonProperty("swe")]
            public string Swe { get; set; }

            [JsonProperty("ukr")]
            public string Ukr { get; set; }

            [JsonProperty("nld")]
            public string Nld { get; set; }

            [JsonProperty("dan")]
            public string Dan { get; set; }

            [JsonProperty("nor")]
            public string Nor { get; set; }

            [JsonProperty("fin")]
            public string Fin { get; set; }

            [JsonProperty("pol")]
            public string Pol { get; set; }

            [JsonProperty("hun")]
            public string Hun { get; set; }

            [JsonProperty("gre")]
            public string Gre { get; set; }

            [JsonProperty("heb")]
            public string Heb { get; set; }

            [JsonProperty("tam")]
            public string Tam { get; set; }

            [JsonProperty("vie")]
            public string Vie { get; set; }

            [JsonProperty("tha")]
            public string Tha { get; set; }

            [JsonProperty("fil")]
            public string Fil { get; set; }

            [JsonProperty("aze")]
            public string Aze { get; set; }

            [JsonProperty("srp")]
            public string Srp { get; set; }

            [JsonProperty("bul")]
            public string Bul { get; set; }

            [JsonProperty("rom")]
            public string Rom { get; set; }

            [JsonProperty("cze")]
            public string Cze { get; set; }

            [JsonProperty("slk")]
            public string Slk { get; set; }

            [JsonProperty("hrv")]
            public string Hrv { get; set; }

            [JsonProperty("slo")]
            public string Slo { get; set; }

            [JsonProperty("lit")]
            public string Lit { get; set; }

            [JsonProperty("est")]
            public string Est { get; set; }

            [JsonProperty("lav")]
            public string Lav { get; set; }

            [JsonProperty("kaz")]
            public string Kaz { get; set; }

            [JsonProperty("tgl")]
            public string Tgl { get; set; }

            [JsonProperty("mlt")]
            public string Mlt { get; set; }

            [JsonProperty("isl")]
            public string Isl { get; set; }

            [JsonProperty("sin")]
            public string Sin { get; set; }

            [JsonProperty("prs")]
            public string Prs { get; set; }

            [JsonProperty("pus")]
            public string Pus { get; set; }

            [JsonProperty("amh")]
            public string Amh { get; set; }

            [JsonProperty("som")]
            public string Som { get; set; }

            [JsonProperty("nob")]
            public string Nob { get; set; }

            [JsonProperty("bos")]
            public string Bos { get; set; }

            [JsonProperty("mya")]
            public string Mya { get; set; }

            [JsonProperty("nep")]
            public string Nep { get; set; }

            [JsonProperty("uzb")]
            public string Uzb { get; set; }

            [JsonProperty("kur")]
            public string Kur { get; set; }

            [JsonProperty("tuk")]
            public string Tuk { get; set; }

            [JsonProperty("bel")]
            public string Bel { get; set; }

            [JsonProperty("kat")]
            public string Kat { get; set; }

            [JsonProperty("tgk")]
            public string Tgk { get; set; }

            [JsonProperty("lat")]
            public string Lat { get; set; }

            [JsonProperty("sqi")]
            public string Sqi { get; set; }

            [JsonProperty("fij")]
            public string Fij { get; set; }

            [JsonProperty("hye")]
            public string Hye { get; set; }

            [JsonProperty("lao")]
            public string Lao { get; set; }

            [JsonProperty("khm")]
            public string Khm { get; set; }
    }

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




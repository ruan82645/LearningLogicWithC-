using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace Desafio_03
{
    internal class Infos

    {
        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("results")]
        public Results[] Results { get; set; }

    }

    public partial class Results
    {

        [JsonProperty("release_date")]
        public DateTimeOffset ReleaseDate { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

    }

}

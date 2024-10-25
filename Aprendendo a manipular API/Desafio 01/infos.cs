using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using RestSharp;

namespace Desafio_01
{
        public partial class Welcome
        {
            [JsonProperty("name")]
            public Name Name { get; set; }

            [JsonProperty("tld")]
            public string[] Tld { get; set; }

            [JsonProperty("cca2")]
            public string Cca2 { get; set; }

            [JsonProperty("ccn3")]
            public string Ccn3 { get; set; }

            [JsonProperty("cca3")]
            public string Cca3 { get; set; }

            [JsonProperty("cioc")]
            public string Cioc { get; set; }

            [JsonProperty("independent")]
            public bool Independent { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("unMember")]
            public bool UnMember { get; set; }

            [JsonProperty("currencies")]
            public Currencies Currencies { get; set; }

            [JsonProperty("idd")]
            public Idd Idd { get; set; }

            [JsonProperty("capital")]
            public string[] Capital { get; set; }

            [JsonProperty("altSpellings")]
            public string[] AltSpellings { get; set; }

            [JsonProperty("region")]
            public string Region { get; set; }

            [JsonProperty("subregion")]
            public string Subregion { get; set; }

            [JsonProperty("languages")]
            public Languages Languages { get; set; }

            [JsonProperty("translations")]
            public Dictionary<string, Translation> Translations { get; set; }

            [JsonProperty("latlng")]
            public long[] Latlng { get; set; }

            [JsonProperty("landlocked")]
            public bool Landlocked { get; set; }

            [JsonProperty("borders")]
            public string[] Borders { get; set; }

            [JsonProperty("area")]
            public long Area { get; set; }

            [JsonProperty("demonyms")]
            public Demonyms Demonyms { get; set; }

            [JsonProperty("flag")]
            public string Flag { get; set; }

            [JsonProperty("maps")]
            public Maps Maps { get; set; }

            [JsonProperty("population")]
            public long Population { get; set; }

            [JsonProperty("gini")]
            public Gini Gini { get; set; }

            [JsonProperty("fifa")]
            public string Fifa { get; set; }

            [JsonProperty("car")]
            public Car Car { get; set; }

            [JsonProperty("timezones")]
            public string[] Timezones { get; set; }

            [JsonProperty("continents")]
            public string[] Continents { get; set; }

            [JsonProperty("flags")]
            public Flags Flags { get; set; }

            [JsonProperty("coatOfArms")]
            public CoatOfArms CoatOfArms { get; set; }

            [JsonProperty("startOfWeek")]
            public string StartOfWeek { get; set; }

            [JsonProperty("capitalInfo")]
            public CapitalInfo CapitalInfo { get; set; }

            [JsonProperty("postalCode")]
            public PostalCode PostalCode { get; set; }
        }

        public partial class CapitalInfo
        {
            [JsonProperty("latlng")]
            public double[] Latlng { get; set; }
        }

        public partial class Car
        {
            [JsonProperty("signs")]
            public string[] Signs { get; set; }

            [JsonProperty("side")]
            public string Side { get; set; }
        }

        public partial class CoatOfArms
        {
            [JsonProperty("png")]
            public Uri Png { get; set; }

            [JsonProperty("svg")]
            public Uri Svg { get; set; }
        }

        public partial class Currencies
        {
            [JsonProperty("BRL")]
            public Brl Brl { get; set; }
        }

        public partial class Brl
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("symbol")]
            public string Symbol { get; set; }
        }

        public partial class Demonyms
        {
            [JsonProperty("eng")]
            public Eng Eng { get; set; }

            [JsonProperty("fra")]
            public Eng Fra { get; set; }
        }

        public partial class Eng
        {
            [JsonProperty("f")]
            public string F { get; set; }

            [JsonProperty("m")]
            public string M { get; set; }
        }

        public partial class Flags
        {
            [JsonProperty("png")]
            public Uri Png { get; set; }

            [JsonProperty("svg")]
            public Uri Svg { get; set; }

            [JsonProperty("alt")]
            public string Alt { get; set; }
        }

        public partial class Gini
        {
            [JsonProperty("2019")]
            public double The2019 { get; set; }
        }

        public partial class Idd
        {
            [JsonProperty("root")]
            public string Root { get; set; }

            [JsonProperty("suffixes")]
            [JsonConverter(typeof(DecodeArrayConverter))]
            public long[] Suffixes { get; set; }
        }

        public partial class Languages
        {
            [JsonProperty("por")]
            public string Por { get; set; }
        }

        public partial class Maps
        {
            [JsonProperty("googleMaps")]
            public Uri GoogleMaps { get; set; }

            [JsonProperty("openStreetMaps")]
            public Uri OpenStreetMaps { get; set; }
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

        public partial class PostalCode
        {
            [JsonProperty("format")]
            public string Format { get; set; }

            [JsonProperty("regex")]
            public string Regex { get; set; }
        }

        public partial class Welcome
        {
            public static Welcome[] FromJson(string json) => JsonConvert.DeserializeObject<Welcome[]>(json, QuickType.Converter.Settings);
        }

        public static class Serialize
        {
            public static string ToJson(this Welcome[] self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
        }

        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
            };
        }

        internal class DecodeArrayConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(long[]);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                reader.Read();
                var value = new List<long>();
                while (reader.TokenType != JsonToken.EndArray)
                {
                    var converter = ParseStringConverter.Singleton;
                    var arrayItem = (long)converter.ReadJson(reader, typeof(long), null, serializer);
                    value.Add(arrayItem);
                    reader.Read();
                }
                return value.ToArray();
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                var value = (long[])untypedValue;
                writer.WriteStartArray();
                foreach (var arrayItem in value)
                {
                    var converter = ParseStringConverter.Singleton;
                    converter.WriteJson(writer, arrayItem, serializer);
                }
                writer.WriteEndArray();
                return;
            }

            public static readonly DecodeArrayConverter Singleton = new DecodeArrayConverter();
        }

        internal class ParseStringConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                long l;
                if (Int64.TryParse(value, out l))
                {
                    return l;
                }
                throw new Exception("Cannot unmarshal type long");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (long)untypedValue;
                serializer.Serialize(writer, value.ToString());
                return;
            }

            public static readonly ParseStringConverter Singleton = new ParseStringConverter();
        }
}




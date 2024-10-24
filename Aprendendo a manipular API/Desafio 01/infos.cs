using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_01
{
        public class Country
        {
            public string NomeAmericano { get; set; }  // name.common
            public string NomeOriginal { get; set; }   // name.nativeName.por.common
            public string Sigla { get; set; }          // cca3
            public List<string> Fronteiras { get; set; }  // borders[]
            public List<string> Linguas { get; set; }  // languages (pode ter várias línguas)
            public int Populacao { get; set; }         // population

            public Country()
            {
                Fronteiras = new List<string>();
                Linguas = new List<string>();
            }
        }
}



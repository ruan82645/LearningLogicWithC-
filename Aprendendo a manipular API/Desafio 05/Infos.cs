using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;

namespace Desafio_05
{
    internal class Infos
    {
        public data[] data {  get; set; }
    }

    partial class data
    {
        public string id { get; set; }
        public string name { get; set; }
        public double min_size { get; set; }
    }
}

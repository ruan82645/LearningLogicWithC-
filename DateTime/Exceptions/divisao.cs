using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class divisao
    {
        public int divisor { get; set; }
        public int dividendo { get; set; }

        public int divididos()
        {
            return dividendo / divisor;
        }
    }
}

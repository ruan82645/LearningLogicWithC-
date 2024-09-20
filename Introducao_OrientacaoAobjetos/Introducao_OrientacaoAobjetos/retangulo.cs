using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao_OrientacaoAobjetos
{
    internal class Retangulo
    {
        public double altura { get; set; }
        public double largura { get; set; }

        public double CalcularArea()
        {
            return altura * largura;
        }
    }

}

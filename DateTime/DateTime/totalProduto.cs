using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ratinho
{
    internal class totalProduto
    {
        public decimal preco {  get; set; }
        public int qnt { get; set; }

        public decimal total()
        {
            return preco * qnt;
        }

    }
}

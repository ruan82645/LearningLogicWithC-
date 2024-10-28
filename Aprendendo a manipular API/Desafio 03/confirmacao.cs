using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_03
{
    internal class confirmacao
    {
        public bool Confirmar(bool continuar)
        {
            Console.WriteLine("ir para a proxima página? (sim ou não?)");
            string confirmacao = Console.ReadLine();
            bool proximaPagina;

            if (confirmacao.ToLower() == "sim" || confirmacao.ToLower() == "não")
            {
                if (confirmacao == "sim")
                {
                    proximaPagina = true;
                    return proximaPagina;
                }
                else
                {
                    proximaPagina = false;
                    return proximaPagina;
                }
            }
            else
            {
                return Confirmar(continuar);
            }
        }
    }
}

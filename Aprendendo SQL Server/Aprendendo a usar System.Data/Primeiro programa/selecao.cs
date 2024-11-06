using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_programa
{
    internal class Selecao
    {
        public string Verificacao()
        {
            Console.WriteLine("digite 'exibir' ou 'editar'");
            string selecao1 = Console.ReadLine();

            if (selecao1.ToLower() == "exibir" || selecao1.ToLower() == "editar")
            {
                return selecao1.ToLower();
            }
            else
            {
                Console.WriteLine("Opção inválida");
                for (int i = 3; i > 0; i--)
                {
                    Console.WriteLine(i + "...");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                return Verificacao();
            }
        }
    }
}

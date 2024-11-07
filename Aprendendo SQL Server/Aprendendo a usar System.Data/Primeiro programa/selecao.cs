using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
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
        //---------------------------------------------------------
        public int SelecaoIndex(DataSet tabela)
        {
            Console.WriteLine("\nselecione um índice");
            string numero = Console.ReadLine();

            int index;
            bool sucesso = int.TryParse(numero, out index);

            if (sucesso)
            {
                if (index > tabela.Tables[0].Rows.Count)
                {
                    Console.WriteLine("índice diferente do que está na lista");
                    return SelecaoIndex(tabela);
                }
                else
                {
                    return index;
                }

            }
            else
            {
                Console.WriteLine("apenas números são aceitos");
                return SelecaoIndex(tabela);
            }
        }
        //-----------------------------------------------------------
        public string VerificacaoDeEdicao()
        {
            string selecao1 = Console.ReadLine().ToLower();

            if (selecao1 == "editar" || selecao1 == "inserir" || selecao1 == "deletar")
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
        //-------------------------------------------------------------
        public int VerificacaoNumeral()
        {
            Console.WriteLine("\nselecione um número");
            string numero = Console.ReadLine();

            int number;
            bool sucesso = int.TryParse(numero, out number);

            if (sucesso)
            {
                return number;
            }
            else
            {
                Console.WriteLine("apenas números são aceitos");
                return VerificacaoNumeral();
            }
        }
    }
}

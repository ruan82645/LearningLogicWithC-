using Primeiro_projeto_Entity.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_simplificado
{
    internal class Listar
    {

        BancoTesteContext contexto = new BancoTesteContext();

        public void ListarClientesCompletos()
        {

            var clientes = contexto.Clientes.ToList();

            foreach (var cliente in clientes)
            {
                Console.WriteLine($"Id: {cliente.IdClient}, Nome:{cliente.Nome}, Telefone:{cliente.Telefone}, Salario:{cliente.Salario.ToString().Replace(".",",")}");
            }
        }

        public void exibirMenuNavegacao()
        {
            Console.WriteLine("Menu - Editar{idCliente} ou Excluir{idCliente}");
            Console.WriteLine("Qual Menu você quer executar?");
        }

        public int ExtrairIdClienteDoTexto(string comando)
        {
            string[] arrayString = comando.Split(" ");
            int idcliente = int.Parse(arrayString[1]);
            return idcliente;
        }

        public string LimparComando(string comando)
        {
            string comandoLimpo = comando.Substring(comando.IndexOf(" ") + 1);
            return comandoLimpo;
        }
    }
}

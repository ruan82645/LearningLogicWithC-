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
        public void ListarClientes()
        {

            AcessoDados db = new AcessoDados();
            var clientes = db.ExecutarSql("select * from Clientes");

            foreach (DataRow cliente in clientes.Tables[0].Rows)
            {
                Console.WriteLine(cliente["id_client"] + " - " + cliente["nome"]);
            }
        }

        public void ListarClientesCompletos()
        {

            AcessoDados db = new AcessoDados();
            var clientes = db.ExecutarSql("select * from Clientes");

            foreach (DataRow cliente in clientes.Tables[0].Rows)
            {
                Console.WriteLine($"ID: {cliente["id_client"]} | NOME:{cliente["nome"]} | EMAIL:{cliente["email"]} | TELEFONE:{cliente["telefone"]} | SALARIO:{cliente["salario"].ToString()} ");
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

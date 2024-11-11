using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_simplificado
{
    internal class Processar
    {
        Listar listar = new Listar();
        int idCliente = 0;
        AcessoDados db = new AcessoDados();
        public void processarEditar(string comando)
        {
            int idCliente = listar.ExtrairIdClienteDoTexto(comando);

            Console.WriteLine($"digite o nome que deseja alterar do id \"{idCliente}\" ");
            string nome = Console.ReadLine();

            int alterados = db.ExecutarNonSql($"update Clientes set nome={nome} where id_client ={idCliente}");

            Console.WriteLine($"sucesso, {alterados} registros alterados");

            listar.ListarClientesCompletos();
        }

        public void processarExcluir(string comando)
        {
            int idCliente = listar.ExtrairIdClienteDoTexto(comando);

            int alterados = db.ExecutarNonSql($"delete from Clientes where id_clientes={idCliente}");

            Console.WriteLine($"sucesso, {alterados} registros deletados");

            listar.ListarClientesCompletos();
        }

        public void processarInserir(string comando)
        {
            string comandoLimpo = listar.LimparComando(comando);

            //{nome}{email}{telefone}{salario}

            string[] DadosInsercao = comandoLimpo.Split(",");

            db.ExecutarNonSql($@"Insert into Clientes
                                (nome,email,telefone,salario)
                                values('{comandoLimpo[1]}','{comandoLimpo[2]}','{comandoLimpo[3]}','{comandoLimpo[4].ToString().Replace(",",".")})");


            listar.ListarClientesCompletos();
        }
    }
}

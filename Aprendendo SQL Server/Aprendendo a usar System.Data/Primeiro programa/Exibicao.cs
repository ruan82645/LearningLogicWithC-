using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace Primeiro_programa
{
    public class Exibicao
    {
        public DataSet BuscarCampos(string query)
        {
            DataSet dataset = new DataSet();

            string database = "Data Source=.; Initial Catalog=Banco_Teste; User ID=ruan;password=ruan82645; MultipleActiveResultSets=True; TrustServerCertificate=True";

            SqlConnection conection = new SqlConnection(database);

            conection.Open();

            SqlCommand command = new SqlCommand(query, conection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(dataset, "tabela1");

            return dataset;
        }

        public void ExibirCampos(string tabelaNome)
        {
            var campos = BuscarCampos($"Select * from {tabelaNome}");
            var tabela = campos.Tables[0];

            foreach (DataRow row in tabela.Rows)
            {
                foreach (DataColumn column in tabela.Columns)
                {
                    if (row[column] == DBNull.Value)
                    {
                        Console.Write($"vazio - ");
                    }
                    else
                    {   
                        Console.Write($"{row[column]} - ");
                    }

                }
                Console.WriteLine();
            }
        }

        public DataSet TrazerColunaComNomeDasTabelas()
        {
            DataSet dataset = new DataSet();

            string database = "Data Source=.; Initial Catalog=Banco_Teste; User ID=ruan;password=ruan82645; MultipleActiveResultSets=True; TrustServerCertificate=True";

            string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";

            SqlConnection conection = new SqlConnection(database);

            conection.Open();

            SqlCommand command = new SqlCommand(query, conection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(dataset, "tabelas");

            return dataset;
        }

        public void ExibirOsNomesDasTabelas()
        {
            var infos = TrazerColunaComNomeDasTabelas();

            for (int i = 0; i < infos.Tables[0].Rows.Count; i++)
            {
                string tableName = infos.Tables[0].Rows[i]["TABLE_NAME"].ToString();

                Console.WriteLine($"{tableName} - [{i}]");
            }
        }

    public DataSet ExibirColunas(string nomeTabela)
        {
            DataSet dataset = new DataSet();

            string database = "Data Source=.; Initial Catalog=Banco_Teste; User ID=ruan;password=ruan82645; MultipleActiveResultSets=True; TrustServerCertificate=True";

            string query = $@"
                SELECT COLUMN_NAME
                FROM INFORMATION_SCHEMA.COLUMNS
                WHERE TABLE_NAME = '{nomeTabela}'";

            SqlConnection conection = new SqlConnection(database);

            conection.Open();

            SqlCommand command = new SqlCommand(query, conection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(dataset, "tabela1");

            return dataset;
        }

    public void ConjuntoDeAcoesParaExibicao()
        {
            Exibicao data = new Exibicao();
            Selecao selecao = new Selecao();
            Tipagem tipagem = new Tipagem();

            var infos = data.TrazerColunaComNomeDasTabelas();
            data.ExibirOsNomesDasTabelas();

            int index = selecao.SelecaoIndex(infos);

            string tabelaEscolhida = $"{infos.Tables[0].Rows[index]["TABLE_NAME"].ToString()}";

            DataSet campos = data.BuscarCampos($"select * from {tabelaEscolhida}");

            foreach (DataRow row in campos.Tables[0].Rows)
            {
                foreach (DataColumn column in campos.Tables[0].Columns)
                {
                    if (row[column] == DBNull.Value)
                    {
                        int m = tipagem.Padding(column, tabelaEscolhida);
                        Console.Write($"vazio".PadRight(m) + " | ");
                    }
                    else
                    {
                        int m = tipagem.Padding(column, tabelaEscolhida);
                        Console.Write($"{row[column]}".PadRight(m) + " | ");
                    }

                }
                Console.WriteLine();
            }
        }

        public string ConjuntoDeAcoesParaExibicaoQueRetornaNomeDaTabela()
        {
            Exibicao data = new Exibicao();
            Selecao selecao = new Selecao();
            Tipagem tipagem = new Tipagem();

            var infos = data.TrazerColunaComNomeDasTabelas();
            data.ExibirOsNomesDasTabelas();

            int index = selecao.SelecaoIndex(infos);

            string tabelaEscolhida = $"{infos.Tables[0].Rows[index]["TABLE_NAME"].ToString()}";

            DataSet campos = data.BuscarCampos($"select * from {tabelaEscolhida}");

            foreach (DataRow row in campos.Tables[0].Rows)
            {
                foreach (DataColumn column in campos.Tables[0].Columns)
                {
                    if (row[column] == DBNull.Value)
                    {
                        int m = tipagem.Padding(column, tabelaEscolhida);
                        Console.Write($"vazio".PadRight(m) + " | ");
                    }
                    else
                    {
                        int m = tipagem.Padding(column, tabelaEscolhida);
                        Console.Write($"{row[column]}".PadRight(m) + " | ");
                    }

                }
                Console.WriteLine();
            }
            return tabelaEscolhida;
        }

    }
}

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
        public DataSet ExibirCampos(string query)
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

        public DataSet ExibirTabelas()
        {
            DataSet dataset = new DataSet();

            string database = "Data Source=.; Initial Catalog=Banco_Teste; User ID=ruan;password=ruan82645; MultipleActiveResultSets=True; TrustServerCertificate=True";

            string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";

            SqlConnection conection = new SqlConnection(database);

            conection.Open();

            SqlCommand command = new SqlCommand(query, conection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(dataset, "tabela1");

            return dataset;
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

    }
}

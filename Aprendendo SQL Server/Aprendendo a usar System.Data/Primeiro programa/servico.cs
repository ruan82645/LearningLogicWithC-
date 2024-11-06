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
    public class servico
    {
        public DataSet Exibir(string query)
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

        public int atualizar(string query)
        {
            string database = "Data Source=.; Initial Catalog=Banco_Teste; User ID=ruan;password=ruan82645; MultipleActiveResultSets=True; TrustServerCertificate=True";

            SqlConnection conection = new SqlConnection(database);

            conection.Open();

            SqlCommand command = new SqlCommand(query, conection);

            int atualizado = command.ExecuteNonQuery();

            return atualizado;
        }
    }
}

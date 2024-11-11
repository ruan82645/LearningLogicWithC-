using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_simplificado
{
    internal class AcessoDados
    {
        public DataSet ExecutarSqL(string query)
        {
            DataSet dataset = new DataSet();
            SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=Banco_Teste; User ID=ruan;password=ruan82645; MultipleActiveResultSets=True; TrustServerCertificate=True");
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataset, "tabela(adapter)");
            return dataset;
        }

        public int ExecutarNonSql(string query)
        {
            SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=Banco_Teste; User ID=ruan;password=ruan82645; MultipleActiveResultSets=True; TrustServerCertificate=True");
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            
            return command.ExecuteNonQuery();

        }
    }
}

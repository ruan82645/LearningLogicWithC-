using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_programa
{
    internal class Edicao
    {
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

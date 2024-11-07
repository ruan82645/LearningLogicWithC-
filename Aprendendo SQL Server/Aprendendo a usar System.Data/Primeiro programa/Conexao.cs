using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_programa
{
    internal class Conexao
    {
        public SqlConnection Connection()
        {
            SqlConnection connection = new SqlConnection("Data Source=.; Initial Catalog=Banco_Teste; User ID=ruan;password=ruan82645; MultipleActiveResultSets=True; TrustServerCertificate=True");
            connection.Open();
            return connection;
        }
    }
}

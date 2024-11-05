
using System.Data.SqlClient;

using (SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=Banco_Teste; User ID=ruan;password=ruan82645; MultipleActiveResultSets=True; TrustServerCertificate=True"))
{
    conn.Open();
    SqlCommand cmd = new SqlCommand("Select * from Clientes", conn);
    SqlDataReader reader = cmd.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine(reader["Nome"]);
    }
}
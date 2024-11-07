using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_programa
{
    internal class Tipagem
    {
        public int Padding(DataColumn column, string nomeTabela)
        {

            string query = $@"
    SELECT CHARACTER_MAXIMUM_LENGTH
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_NAME = '{nomeTabela}'
    AND COLUMN_NAME = '{column.ColumnName}'
    AND DATA_TYPE IN ('varchar', 'nvarchar', 'char')";

            Conexao connect = new Conexao();
            var connection = connect.Connection();

            using (SqlCommand command = new SqlCommand(query, connection))
            {

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int maxLength;

                        if (reader["CHARACTER_MAXIMUM_LENGTH"] != DBNull.Value)
                        {
                            maxLength = Convert.ToInt32(reader["CHARACTER_MAXIMUM_LENGTH"]);
                            return maxLength;
                        }
                        else
                        {
                            maxLength = 10;
                            return maxLength;
                        }

                    }
                    return 10;
                }

            }
        }
    }
}

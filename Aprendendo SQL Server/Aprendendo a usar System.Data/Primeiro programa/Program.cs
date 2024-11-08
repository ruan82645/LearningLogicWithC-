
using Primeiro_programa;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;

Exibicao data = new Exibicao();
Selecao selecao = new Selecao();
Tipagem tipagem = new Tipagem();


Console.WriteLine("O que deseja fazer?");
Console.WriteLine("Exibir ou editar alguma tabela?");

string selecao1 = selecao.Verificacao();

if (selecao1 == "exibir")
{
    data.ConjuntoDeAcoesParaExibicao(); 
}
else if (selecao1 == "editar")
{
    string nomeTabela = data.ConjuntoDeAcoesParaExibicaoQueRetornaNomeDaTabela();

    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("*editar* registro, *inserir* novo registro, *deletar* registro");
    Console.WriteLine("digite uma das palavras chave");

    string selecaoEdicao = selecao.VerificacaoDeEdicao();

    if (selecaoEdicao == "editar")
    {
        Console.WriteLine("De quem é o id que deseja editar?");
        int id = selecao.VerificacaoNumeral();

        Console.WriteLine("digite os dados separados por virgula");
        DataSet colunas = data.BuscarDadosDasColunas(nomeTabela);

        foreach (DataRow campo in colunas.Tables[0].Rows)
        {
            if (!(campo.ItemArray[0].ToString().Contains("id"))  )
            {
                Console.Write($"{campo.ItemArray[0].ToString()},");
            }
           
        }

        string alteracao = Console.ReadLine();

        string[] alteracoes = alteracao.Split(',');

        int i = 0;
        foreach (string campo in colunas.Tables[0].Rows)
        {
            if (!(campo.Contains("id")) || !(campo.Contains("Id")))
            {
                
                foreach (var alts in alteracoes)
                {
                    string query = $@"uptade {nomeTabela} set {campo} = '{alts[i]}'";
                }
            }
              
        }
        

        Console.WriteLine();


    }
    else if (selecaoEdicao == "inserir")
    {
        Conexao con = new Conexao();
        var conn = con.Connection();

        DataSet dataSet = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM INFORMATION_SCHEMA.TABLES", conn);
            adapter.Fill(dataSet, "Tabelas");

            // Carregar os metadados das colunas da tabela escolhida
            SqlDataAdapter columnAdapter = new SqlDataAdapter($"SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}'", connection);
            DataTable columnsTable = new DataTable();
            columnAdapter.Fill(columnsTable);


            var inserirColunas = new List<(string Name, string DataType)>();

            Console.WriteLine("Campos disponíveis para preenchimento:");
            foreach (DataRow columnRow in columnsTable.Rows)
            {
                string columnName = columnRow["COLUMN_NAME"].ToString();
                string dataType = columnRow["DATA_TYPE"].ToString();

                if (!columnName.ToLower().Contains("id"))
                {
                    inserirColunas.Add((columnName, dataType));  
                }
            }
            Console.WriteLine();

            // Coletar os valores do usuário de acordo com o tipo de dado esperado
            var valoresParaPassar = new List<SqlParameter>();
            foreach (var (Name, DataType) in inserirColunas)
            {
                Console.Write($"Insira o valor para '{Name}' ({DataType}): ");
                string input = Console.ReadLine();

                // Converter o valor de entrada de acordo com o tipo de dado
                object convertedValue;
                switch (DataType.ToLower())
                {
                    case "int":
                        convertedValue = int.Parse(input);
                        break;
                    case "decimal":
                        convertedValue = decimal.Parse(input);
                        break;
                    case "datetime":
                        convertedValue = DateTime.Parse(input);
                        break;
                    default:
                        convertedValue = input; // para tipos string e outros
                        break;
                }

                // Adicionar o valor como um parâmetro SQL
                valoresParaPassar.Add(new SqlParameter($"@{Name}", convertedValue));
            }

            // Construir e executar a query de inserção com parâmetros
            string insertQuery = $"INSERT INTO {tableName} ({string.Join(", ", inserirColunas.Select(c => c.Name))}) " +
                                 $"VALUES ({string.Join(", ", inserirColunas.Select(c => $"@{c.Name}"))})";

            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddRange(valoresParaPassar.ToArray());
                command.ExecuteNonQuery();
                Console.WriteLine("Novo registro inserido com sucesso!");

            }
    else if(selecaoEdicao == "deletar")
    {

        Console.WriteLine("De quem é o id que deseja deletar o registro?");
        int id = selecao.VerificacaoNumeral();

        DataSet coluna = data.BuscarDadosDasColunas(nomeTabela);

        Conexao con = new Conexao();
        var connection = con.Connection();

        SqlCommand Command = new SqlCommand($"delete from {nomeTabela} where {coluna.Tables[0].Rows[0]["COLUMN_NAME"].ToString()} = {id}", connection);
        Command.ExecuteNonQuery();
    }
    else
    {

    }
}

Console.ReadKey();








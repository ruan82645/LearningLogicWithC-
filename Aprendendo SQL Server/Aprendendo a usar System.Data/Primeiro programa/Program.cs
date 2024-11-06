
using Primeiro_programa;
using System.Data;
using System.Data.Sql;

Exibicao data = new Exibicao();
Selecao selecao = new Selecao();


Console.WriteLine("O que deseja fazer?");
Console.WriteLine("Exibir ou editar alguma tabela?");

string selecao1 = selecao.Verificacao();

if(selecao1 == "exibir")
{
    var infos = data.ExibirTabelas();

    for(int i = 0; i < infos.Tables[0].Rows.Count; i++)
    {
        string tableName = infos.Tables[0].Rows[i]["TABLE_NAME"].ToString();

        Console.WriteLine($"{tableName} - [{i}]");
    }

    
}

Console.ReadKey();

string query = "select * from Clientes";
DataSet table = data.ExibirCampos(query);

foreach (DataRow column in table.Tables[0].Rows)
{
    Console.WriteLine($@"{column["nome"]} - {column["email"]}");
}




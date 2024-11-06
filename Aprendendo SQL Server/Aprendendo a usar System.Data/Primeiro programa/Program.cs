
using Primeiro_programa;
using System.Data;
using System.Data.Sql;

Exibicao data = new Exibicao();
Selecao selecao = new Selecao();


Console.WriteLine("O que deseja fazer?");
Console.WriteLine("Exibir ou editar alguma tabela?");

string selecao1 = selecao.Verificacao();

if (selecao1 == "exibir")
{
    var infos = data.ExibirTabelas();

    for (int i = 0; i < infos.Tables[0].Rows.Count; i++)
    {
        string tableName = infos.Tables[0].Rows[i]["TABLE_NAME"].ToString();

        Console.WriteLine($"{tableName} - [{i}]");
    }
    Console.WriteLine();
    Console.WriteLine("selecione o indice de quem quer exibir");

    int j;

    string numero = Console.ReadLine();

    bool sucesso = int.TryParse(numero, out j);

    if (sucesso)
    {
        if (j > infos.Tables[0].Rows.Count)
        {
            Console.WriteLine("ERRO");
        }
        else
        {
            var campos = data.ExibirCampos($"Select * from {infos.Tables[0].Rows[j]["TABLE_NAME"].ToString()}");
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

    }
    Console.ReadKey();
}






using Primeiro_programa;
using System.Data;
using System.Data.Common;
using System.Data.Sql;

Exibicao data = new Exibicao();
Selecao selecao = new Selecao();
Tipagem tipagem = new Tipagem();    


Console.WriteLine("O que deseja fazer?");
Console.WriteLine("Exibir ou editar alguma tabela?");

string selecao1 = selecao.Verificacao();

if (selecao1 == "exibir")
{
    var infos = data.TrazerColunaComNomeDasTabelas();
    data.ExibirOsNomesDasTabelas();
    //-------------------------------------------------
    int index = selecao.SelecaoIndex(infos);

    string tabelaEscolhida = $"{infos.Tables[0].Rows[index]["TABLE_NAME"].ToString()}";

    DataSet campos = data.BuscarCampos($"select * from {tabelaEscolhida}");

    foreach (DataRow row in campos.Tables[0].Rows)
    {
        foreach (DataColumn column in campos.Tables[0].Columns)
        {
            if (row[column] == DBNull.Value)
            {
                int m = tipagem.Padding(column);
                Console.Write($"vazio".PadRight(m) + "- ");
            }
            else
            {
                int m = tipagem.Padding(column);
                Console.Write($"{row[column]}".PadRight(m) + "- ");
            }

        }
        Console.WriteLine();
    }
}









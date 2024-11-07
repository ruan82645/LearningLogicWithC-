
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
    data.ConjuntoDeAcoesParaExibicao(); 
}
else if (selecao1 == "editar")
{
    var infos = data.TrazerColunaComNomeDasTabelas();
    data.ExibirOsNomesDasTabelas();

    int index = selecao.SelecaoIndex(infos);

    string tabelaEscolhida = $"{infos.Tables[0].Rows[index]["TABLE_NAME"].ToString()}";

    DataSet campos = data.BuscarCampos($"select * from {tabelaEscolhida}");


}

Console.ReadKey();








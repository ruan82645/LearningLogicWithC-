
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
        Console.WriteLine(colunas.Tables[0].Rows.Count.ToString());
        Console.ReadKey();

    }
    else if (selecaoEdicao == "inserir")
    {

    }
    else if(selecaoEdicao == "deletar")
    {

    }
    else
    {

    }
}

Console.ReadKey();








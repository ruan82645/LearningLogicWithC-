
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
    var infos = data.BuscarTabelas();
    var tabela = infos.Tables[0];

    data.ExibirTabelas();

    Console.WriteLine("\nselecione o indice de quem quer exibir");

    int index;

    string numero = Console.ReadLine();

    bool sucesso = int.TryParse(numero, out index);

    if (sucesso)
    {
        if (index > infos.Tables[0].Rows.Count)
        {
            Console.WriteLine("ERRO");
        }
        else
        {
            data.ExibirCampos(tabela.Rows[index]["TABLE_NAME"].ToString());
        }

    }
    Console.ReadKey();
}





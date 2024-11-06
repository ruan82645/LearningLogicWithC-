
using Primeiro_programa;
using System.Data;
using System.Data.Sql;

servico data = new servico();


Console.WriteLine("O que deseja fazer?");
Console.WriteLine("Exibir ou editar alguma tabela?");
Console.WriteLine("digite 'exibir' ou 'editar'");

Console.WriteLine("Opção inválida");

for (int i = 3; i == 1; i--)
{
    Console.WriteLine(i + "...");
    Thread.Sleep(1000);
    Console.Clear();
}


string selecao1 = Console.ReadLine();

if(selecao1.ToLower() == "exibir")
{

}
else if(selecao1.ToLower() == "editar")
{

}
else
{
    Console.WriteLine("Opção inválida");
}

string query = "select * from Clientes";
DataSet table = data.Exibir(query);

foreach (DataRow column in table.Tables[0].Rows)
{
    Console.WriteLine($@"{column["nome"]} - {column["email"]}");  
}




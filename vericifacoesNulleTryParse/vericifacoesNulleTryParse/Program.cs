using System.Text.RegularExpressions;
using DateTime;

totalProduto totalico = new totalProduto();

string? nome = " ";
decimal? preco = 0;
int? quantidade = 0;
int quantidadeValido = 0;
decimal precoValido = 0;



while (true)
{
    Console.WriteLine("Qual produto você quer adicionar?");

    var InputNome = Console.ReadLine();

    if (string.IsNullOrEmpty(InputNome))
    {
        Console.WriteLine("digite o nome do produto em estoque");
    }
    else
    {
        nome = InputNome;
        if (!isValidName(nome))
        {
            Console.WriteLine("O nome não pode ter caracteres especiais ou números");
        }
        else
        {
            break;
        }
    }
}

while (true)
{
    Console.WriteLine("digite o preço por favor");
    var inputPreco = Console.ReadLine();

    if (string.IsNullOrEmpty(inputPreco))
    {
        Console.WriteLine("não deixe os valores em branco");
    }
    else
    {
        if (decimal.TryParse(inputPreco, out precoValido))
        {
            preco = precoValido;
            break;
        }
        else
        {
            Console.WriteLine("o valor está em formato incorreto");
        }

    }
}

while (true)
{
    Console.WriteLine("quantos itens tem no estoque?");
    var inputQuantidade = Console.ReadLine();

    if (string.IsNullOrEmpty(inputQuantidade))
    {
        Console.WriteLine("digite a quantidade de " + nome);
    }
    else
    {
        if (int.TryParse(inputQuantidade, out quantidadeValido))
        {
            quantidade = quantidadeValido;
            break;
        }
        else
        {
            Console.WriteLine("valor digitado não está certo, verifique a ortografia e tente novamente");
        }
    }


}

totalico.qnt = quantidadeValido;
totalico.preco = precoValido;

Console.WriteLine("O valor total de " + nome + " em estoque é R$:" + totalico.total().ToString("F2"));

static bool isValidName(string name)
{
    Regex valicao = new Regex(@"^[a-zA-Z\s]+$");
    return valicao.IsMatch(name);

}
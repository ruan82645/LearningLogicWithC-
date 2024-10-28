// Nesse desafio, devo utilizar a Api da CoinBase(https://api.coinbase.com/v2/currencies) para:
// exibir os dados de forma organizada e exibir o valor minimo em 6 casas decimais

using Desafio_05;

Api api = new Api();

Infos dados = await api.Request();

foreach (var info in dados.data)
{
    Console.WriteLine(new string('-',30));
    Console.WriteLine(info.id);
    Console.WriteLine(info.name);
    Console.WriteLine(info.min_size.ToString("N6"));
}
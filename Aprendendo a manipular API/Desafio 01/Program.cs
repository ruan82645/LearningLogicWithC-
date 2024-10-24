// Nesse Desafio, devo condumir a api: https://restcountries.com/v3.1/all
// Nela eu devo consultar um país, e exibir população, nome e lingua falada em todos os paises de fronteira

using Desafio_01;
//Digite o pais que quer saber a fronteira
Console.WriteLine("Digite o país que quer saber das fronteiras");
string name = Console.ReadLine();

//executar busca de fronteira
Api api = new Api();

List<Country> country = await api.ConsultarFronteiras(name);
//foreach com todas as siglas

foreach (string sigla in country[0].Fronteiras)
{
    int i = 1;
    List<Country> pais = await api.Fronteira(sigla);

    Console.WriteLine($"{pais[0].NomeOriginal}/{pais[0].NomeAmericano}");
    foreach(string lingua in pais[0].Linguas)
    {
        Console.WriteLine($"língua {i} - {lingua}");
        i++;
    }
    Console.WriteLine($"População: {pais[0].Populacao}");
}



// Nesse Desafio, devo condumir a api: https://restcountries.com/v3.1/all
// Nela eu devo consultar um país, e exibir população, nome e lingua falada em todos os paises de fronteira

using Desafio_01;
//Digite o pais que quer saber a fronteira
Console.WriteLine("Digite o país que quer saber das fronteiras");
string name = Console.ReadLine();

//executar busca de fronteira
Api api = new Api();

Country country = await api.ConsultarFronteiras(name);
//foreach com todas as siglas

foreach (string sigla in country.Borders)
{
    int i = 1;
   Country pais = await api.Fronteira(sigla);

    if(pais.Name.NativeName == null)
    {
        Console.WriteLine("null");
    }

    Console.WriteLine("Nomes originais:");

        foreach(var lingua in pais.Name.NativeName.Values)
    {
        Console.WriteLine($"{lingua.Common}");
    };

    Console.WriteLine("Nome americano:");

    Console.WriteLine($"{pais.Name.Common}");


    foreach (var lingua in pais.Languages)
    {
        Console.WriteLine($"língua {i} - {lingua.Value}");
        i++;
    }
    Console.WriteLine($"População: {pais.Population}");
}



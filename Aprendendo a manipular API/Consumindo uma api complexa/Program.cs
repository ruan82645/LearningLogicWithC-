// Aqui, devemos consumir uma api um pouco mais complexa: https://datausa.io/api/data?drilldowns=Nation&measures=Population,
// Ela informa dados da população dos EUA de todos os anos separados por objeto
// Esses objetos estão dentro de um array, porém existem outros arrays que podemos capturar.
// Quando precisamos criar uma classe para armazenar informações de uma APi que tenham arrays de objetos,
// primeiro criamos uma classe para identificar os arrays e seus nomes
// depois criamos uma classe para organizar o conteudo de cada array e suas informações

// Eu não fiz essa essa classe à mão, usei o site "https://app.quicktype.io/" para criar ela para mim

// Aqui devemos exibir as populações de todos os anos que estejam na Api.


using Armazenamento;
using Consumindo;

Api api = new Api();

Console.WriteLine("Sobre qual ano quer saber?");
string year = Console.ReadLine();

Geral.Welcome infos = api.Consumir(year);

foreach (var info in infos.Data)
{
    Console.WriteLine($"Ano: {info.Year} - {info.Population}");
}
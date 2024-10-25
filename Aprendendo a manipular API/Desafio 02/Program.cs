// Nesse desafio deveremos consumir a api do GitHub: https://api.github.com/users/<username>/repos,
// e trazer alguns dados sobre todos os repositorios do usuario

// nomes dos repositorio, linguagem, numero de estrelas, numero de forks 

using Desafio_02;

Api api = new Api();    

Console.WriteLine("digite o usuario");
string usuario = Console.ReadLine();

var repositorios = await api.Verificar(usuario);

foreach(var repositorio in repositorios)
{
    Console.WriteLine();
    Console.WriteLine($"nome: {repositorio.Name}");
    Console.WriteLine($"linguagem: {repositorio.Language}");
    Console.WriteLine($"estrelas: {repositorio.Starsgazers_count}");
    Console.WriteLine($"forks: {repositorio.Forks_count}");
    Console.WriteLine();
}



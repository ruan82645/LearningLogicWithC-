using IdadePeloNome;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Globalization;
using System.Threading.Tasks;
using GeneroPorNome;
using static GeneroPorNome.GeneroPorNome;

class Program
{
    static async Task Main(string[] args)
    {

        //Nesse exercicio vamos consumir uma Api simples que "tenta" dizer sua idade
        //de acordo com o seu nome

        Console.WriteLine("Digite seu nome e eu tentarei descobrir sua idade");
        string nome = Console.ReadLine();

        Solicitando solicitando = new Solicitando();

        int idade = solicitando.solicitar(nome);

        Console.WriteLine(idade);




        //Neste outro exercicio, devemos consumir uma Api que prevê o gênero pelo nome

        ApiGenderize genero = new ApiGenderize();

        string nome2 = "Ruan";

        string gender = await genero.GetGenderAsync(nome2);

        Console.WriteLine(gender);

    }

}

using Consumindo_Api_pelo_Rest_Sharp;
using RestSharp;
using System;
using System.Globalization;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {

        Console.WriteLine("Digite seu nome e eu tentaarei descobrir sua idade");
        string nome = Console.ReadLine();
        
        Solicitando solicitando = new Solicitando();

        int idade = solicitando.solicitar(nome);

        Console.WriteLine(idade);
    }
}
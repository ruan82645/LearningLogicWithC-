// Serialização é o processo inverso, transformar um codigo na linguagem que está escrevendo em Json

// Nesse caso em especifico, vamos usar o mesmo material usado na Desserialização,
// vamos pegar um arquivo com um json dentro, converter para C#, mas dessa vez,
// vamos alterar informações e salvar em um arquivo separado

using Newtonsoft.Json;
using System;
using Serialização;

class Program
{
    static void Main(string[] args)
    {
        // Exemplo de JSON
        string jsonSalvo = "JsonAlterado.txt";
        string json = System.IO.File.ReadAllText("cep.txt");

        // Desserializando o JSON

        Endereco book = JsonConvert.DeserializeObject<Endereco>(json);

        // Exibindo os dados
        Console.WriteLine($"CEP: {book.Cep}");
        Console.WriteLine($"Logradouro: {book.Logradouro}");
        Console.WriteLine($"Complemento: {book.Complemento}");
        Console.WriteLine($"Bairro: {book.Bairro}");
        Console.WriteLine($"Localidade: {book.Localidade}");
        Console.WriteLine($"UF: {book.Uf}");
        Console.WriteLine($"IBGE: {book.Ibge}");
        Console.WriteLine($"GIA: {book.Gia}");
        Console.WriteLine($"DDD: {book.Ddd}");
        Console.WriteLine($"SIAFI: {book.Siafi}");

        book.Uf = "DF";
        book.Cep = "71070-522";

        string JsonConverted = JsonConvert.SerializeObject( book );
        File.WriteAllText(jsonSalvo, JsonConverted );



    }
}
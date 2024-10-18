// Como dito antes, a Desserialização é o processo de converter um Json vindo de uma API,
// em um código que o nosso programa consiga ler e interpretar.
// Vamos pensar em algumas coisas, como por exemplo um objeto Json,
// ele virá em forma de objeto JavaScript, muitas das coisas precisam ser armazenadas
// então precisamos criar objetos para isso.

// Nesse programa, vamos usar o NuGet Newtonsoft.Json!!!

// Digamos que tenha algo como:
//{ nome: Roberto,
// endereco: rua 22,
// idade: 20}

// precisamos ter uma classe para armazenar essas informações ao converter, 
// e ai podemos utilizar. Claro que isso ocorre quando é um objeto!! Não vamos generalizar

//---------------------------------------------------------------------------------------------

// Nesse exercicio, vamos desserializar um Json que está em um arquivo texto
// foi pedido um código base para o gpt, e vamos alterar ele para nossa utilização

using Newtonsoft.Json;
using System;
using Desserialização_Json;

class Program
{
    static void Main(string[] args)
    {
        // Exemplo de JSON
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
    }
}

// entenda uma coisa também, caso hajam dados a mais na api que vc não esteja usando, não vai dar problema,
// nesse Json, imagine se tivesse mais 3 tipos de informação, como país, planeta, etc.
// se eu não usalos, não vai ter nenhum problema, mesmo que estejam incluidos na classe o seu tipo de informação,
// se eu não usa-los no código, não haverá problema. Por que? Imagine que a empresa dona da API faz uma ataulização,
// caso eu fosse obrigado a usar tudo que existe naquele objeto Json, o programa iria parar até eu saber da atualização
// e então adicionar a nova informação. Porém já que não é necessário incluir tudo, eu posso em outro momento,
// fazer a manutenção do sistema.



//Substring serve para pegar somente uma parte desejada de uma string
//lembre, o valor alterado de uma string, tem que ir para outra string
//simples assim, mas como funciona?

//Ao chamar a nomeação da string e usar ".substring", podemos passar 2 valores
//sendo o primeiro obrigatório e o segundo opcional

// 1° valor: de onde começa o que eu quero pegar dessa string
// 2° valor: quantos Char a frente eu quero pegar (pega tudo caso não definido)

//vamos ao exemplo:

using System;
using System.ComponentModel.DataAnnotations;


string Exemplo1 = "ruan pablo alves da costa";
string GuardaValor = Exemplo1.Substring(3, 10);
// resultado: "n pablo al"
//vou pegar do 4°(index) caracter até 10 caracteres a frente

//mais um exemplo, sem passar o segundo valor

string Exemplo2 = "ruan pablo alves da cotsa";
string GuardaValor2 = Exemplo2.Substring(1);
// resultado: "uan pablo alves da costa"
//pegou do 2°(index) caracter até o final já que não havia especificação

//Veja mais exercicios a frente


//Esse é bem simples, sendo para imprimir cada nome sem as numerações
//usei o split para separar e imprimir cada um em uma linha
//e o Substring para retirar as numerações
//string Exercicio1 = "1)Charles;2)Kaique;3)Janderson;4)Renato;5)Barbara";
//Console.WriteLine(Exercicio1);

//string[] ListaDeNomes = Exercicio1.Split(';');

// foreach(string nome in ListaDeNomes)
//{
//    Console.WriteLine(nome.Substring(2));
//}


//meu amigo... esse eu demorei pra fazer, já que até aqui eu não conhecia outros metodos
//o objetivo era pegar cada nome, separar por ";" e depois exibiir nome e sobrenome separados
//primeiro nome: fulano | segundo nome: ciclano
//para isso, no primeiro nome, eu imprimi caracter por caracter até chegar no espaço
//depois disso, eu criei uma int index pra contar junto com o loop, me dizendo a posição
//usei esse index para informar ao substring de onde eu queria pegar e ir até o fim

//Console.WriteLine("por favor, digite nomes e sobrenomes e sobrenome separados por \";\"");
//Console.WriteLine("José Paulo;Renata Ribeiro;Flavio Gonçalves");
//string nome2 = Console.ReadLine();


//string[] listaNomes = nome2.Split(";");

//string primeiroNome = "";
//string segundoNome = "";
//int index = 0;

//foreach (string nome in listaNomes)
//{
//    index = 0;
//    Console.Write("Primeiro nome: ");
//    foreach (char n in nome)
//    {

//        index++;
//        Console.Write(n);
//        if(n == ' ')
//        {
//            break;
//        }

//    }

//    Console.Write("| Sobrenome :" + nome.Substring(index - 1));
//    Console.WriteLine();
//}

//Console.ReadKey();

//esse aqui é realmente bem simples
//a pessoa digita o email e informamos qual o dominio
//substring só funciona com numeros, então descobrimos o número do "@"
//e depois imprimimos no console

//Console.WriteLine("digite seu email");
//string email = Console.ReadLine();

//for (int i = 0; i < email.Length; i++)
//{
//    if(email[i] == '@')
//    {
//        Console.WriteLine(email.Substring(i + 1));
//    }
//}


//Aqui, o usuario digita nome e sobrenome e aparece a abreviação do sobrenome

//Console.WriteLine("Digite seu nome para ser abreviado");
//string nomeParaAbreviar = Console.ReadLine();

//string[] ArrayNomeParaAbreviar = nomeParaAbreviar.Split(" ");

//Console.Write(ArrayNomeParaAbreviar[0] + " ");

//Console.Write(ArrayNomeParaAbreviar[1].Substring(0,1));

//Esse aqui tbm é bem facil, a pessoa digita uma palavra
//e depois quantos ultimos caracteres  dessa palavra ela quer
//depois é exibido essa palavra

//Console.WriteLine("digite uma palavra");
//string algumaCoisa = Console.ReadLine();
//Console.WriteLine();
//Console.WriteLine("Quais ultimos caracteres você quer ver?");
//int numero = int.Parse(Console.ReadLine());

//Console.WriteLine(algumaCoisa.Substring(algumaCoisa.Length - numero));
















// o metodo Join é "simples" de raciocinar
// ele junta o que tiver em um array de string em uma string
// então digamos que vc dividiu um array com o split()
// se quiser juntar ele novamente, com espaços ou outro caracter, use o Join
// como assim com espaços ou outro caracter?
// digamos que vc tenha a frase "amanhã vou comprar pipa"
// ela foi desmontada num array pelo split.
// se imprimir, vai vir tudo junto: "amanhãvoucomprarpipa"
// mas com o Join, especificamos o que queremos entre cada string
// devemos determinar uma string ou char que será colocada entre cada palavra
// E após isso, um array de strings para que seja unido
// ele vai juntar cada palavra com aquilo que voce determinou
// NÃO É POSSIVEL JUNTAR UM TEXTO EM OUTRO TEXTO

using System.Net.Http.Headers;
using System.Threading.Channels;

string Exemplo1 = "meu pai foi no médico hoje";
string[] palavras = Exemplo1.Split();

string TudoJuntoMisturado = string.Join(",", palavras);
//vai retornar: "meu,pai,foi,no,médico,hoje"

//vamos ao exemplo 2

string Exemplo2 = "ruan,renato,jorge,fernando";
string[] palavras2 = Exemplo2.Split(",");

string TudoJuntoMisturado2 = string.Join("-", palavras2);
Console.WriteLine(TudoJuntoMisturado2);
//vai retornar: "nome: ruan"

//vamos ao exercicios de Join

// 1) Esse bem simples, para aquecer
//juntar uma lista de palavras em uma string separada por virgulas

//Console.WriteLine("digite varias palavras sepadas");
//string palavrasDigitadas = Console.ReadLine();

//string[] ArraydePalavras = palavrasDigitadas.Split(" ");

//string palavrasUnidas = string.Join(",", ArraydePalavras);

//Console.WriteLine(palavrasUnidas);


// 2) Esse é como o de cima, mas já começa como se tivessemos um array com palavras

string[] listaDePalavras = { "C#", "é", "uma", "linguagem", "de", "programação" };

Console.WriteLine(string.Join(" ", listaDePalavras));


// 3) Nesse colocar [] antes e depois de cada numero digitado
//Aqui, eu peguei cada string do array, coloquei em colchetes e só depois juntei=
//Console.WriteLine("digite alguns números");
//string numeros = Console.ReadLine();

//string[] numerosArray = numeros.Split(" ");



//for(int i = 0; i < numerosArray.Length; i++)
//{
//    numerosArray[i] = $"[{numerosArray[i]}]";
//}

//string numerosEmColchetes = string.Join(" ", numerosArray);
//Console.WriteLine(numerosEmColchetes);


// 4) Nesse eu levei um pouco mais de tempo para raciocinar como faria uma coisa
//como não escrever " " no final da ultima letra
//a ideia foi fazer dois ifs para fazer a verificação
//depois disso, bastava juntar cada letra em uma unica string nova e juntar com "-"

//Console.WriteLine("digite uma palavra");
//string palavra3 = Console.ReadLine();

//string caractere = "";

//for(int i = 0;i <= palavra3.Length; i++)
//{
//    if (i < palavra3.Length-1)
//    {
//        caractere = caractere + $"{palavra3[i]} ";
//    }
//    if(i == palavra3.Length-1)
//    {
//        caractere = caractere + $"{palavra3[i]}";
//        break;
//    }

//}
//string[] CaracteresSeparados = caractere.Split(" ");

//Console.WriteLine(string.Join("-",CaracteresSeparados));


// 5) Nesse, nós dizemos varias palavras separadas por espaço
//O programa então adiciona virgulas entre as palavras
//mas entre as ultimas duas, ele coloca um "e"
//ficando assim: "carro, moto, caminhão, jetski e trator";
//take funciona como um slice, ele pega uma quatidade de itens do array que vc pediu
//so que no final, tem que converter pra array de novo
//aqui ele pega tudo, menos o ultimo item, ele sempre começa do inicio do array

//Console.WriteLine("Escreva palavras separadar por espaço");
//string texto = Console.ReadLine();

//string[] ArrayTexto = texto.Split(" ");
//string[] textoVirgula = ArrayTexto.Take(ArrayTexto.Length - 1).ToArray();

//string final = $"{string.Join(",", textoVirgula)} e {ArrayTexto.Length - 1}";
//Console.WriteLine(final);


//Bem simples esse, colocar "item: " antes de cada palavra digitada
//
//
//Console.WriteLine("digite palavras separadas por virgula");
//string text = Console.ReadLine();

////maçã,banana,melancia,morango
////item: maçã, item: banana, item: melancia

//string[] ArrayCompras = text.Split(",");

//string Compras = string.Join(",item: ", ArrayCompras);
//string ComprasFinal = $"item: {Compras}";

//Console.WriteLine(ComprasFinal);


//aqui, o usuario diz algumas palavras, e essas palavras devem aparecer como ul
//formatado como se fosse um html
// escrevi: "ronaldo,jorge"
// e apareceu: <ul>
//                 <li>ronaldo</li>
//                 <li>jorge</li>
//             </ul>
// entendeu? simples e fácil, só usar alguns /n para isso

Console.WriteLine("escreva palavras para entrarem na lista HTML");
string ul =  Console.ReadLine();
string[] ArrayUl = ul.Split(",");

//ruan,jorge,renato,garcia
string html = string.Join("</li>\n    <li>", ArrayUl);
string htmlFinal = $"<ul>\n    <li>{html}</li>\n</ul>";
Console.WriteLine(htmlFinal);

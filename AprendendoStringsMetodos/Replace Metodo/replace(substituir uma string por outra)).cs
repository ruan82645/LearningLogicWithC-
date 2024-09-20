// Metodo Replace é bem tranquilo
// se trata de um metodo para substituir uma string que vc deseja por outra
// escolhemos oq queremos trocar, e pelo que queremos trocar
// então numa frase queremos trocar todos os "a" por "A", usamos Replace
// ou palavras inteiras tbm. trocar vermelho por azul por exemplo
// lembrando que ele troca todas as incidencias, não é só na primeira vez

// exemplo: 

string Exemplo1 = "meu carro é vermelho brilhante";

string Replaced = Exemplo1.Replace("vermelho", "azul");
// "meu carro é azul brilhante"
// também podemos pedir para o usuario digitar aquelas duas propriedades
// agora para o exemplo 2

string Exemplo2 = "Hoje eu fui na praia e almocei na agua";
string busca = "a";
string troca = "A";

string Replaced2 = Exemplo2.Replace(busca, troca);
// "Hoje eu fui nA prAiA e Almocei nA AguA"
// viu? coloquei variaveis tipo string lá nas propriedades obrigatorias

//vamos para as atividades;


//Bem simples, pedir para o usuario digitar algo
//depois substituir os espaços por "-"

//Console.WriteLine("digite uma frase por favor");
//string frase = Console.ReadLine();

//string substituido = frase.Replace(" ", "-");
//Console.WriteLine(substituido);


//Esse foi bem tranquilo também
//O usuario passa alguma coisa e o programa remove todas as vogais

//Console.WriteLine("diga uma palavra para tirar as vogais");
//string palavraComVogal = Console.ReadLine();

//string palavraSemA = palavraComVogal.Replace("a", "");
//string palavraSemE = palavraSemA.Replace("e", "");
//string palavraSemI = palavraSemE.Replace("i", "");
//string palavraSemO = palavraSemI.Replace("o", "");
//string palavraSemU = palavraSemO.Replace("u", "");

//Console.WriteLine(palavraSemU);

//Aqui não é dificil, mas sei que vai se confundir algum momento com isso
//no foreach, a cada iteração, ele está censurando uma palavra
//na primeira passada, ele censurou todos os "porra" e armazenou essa frase sem porra
//na proxima, ele pegou a frase sem o "porra" e censurou os "merda" e armazenou sem esses dois
//e assim por diante até acabar todo o array de palavras para censurar 
//no fim ele imprime tudo censurado

//Console.WriteLine("digite uma frase xingando");
//string fraseXingada = Console.ReadLine();
//string Censurado = " ";

//string[] xingamentos = { "porra", "merda", "caralho", "arrombado", "burro", "inutil", "corno", "viado", "puta"  };

//foreach(string palavrao in xingamentos)
//{
//    fraseXingada = fraseXingada.Replace(palavrao.ToString(), "*****");

//}

//Console.WriteLine(fraseXingada);


//Nesse, o usuario deve informar uma frase que contenham numeros
//então o programa  deve substituir os números por numeros por extenso

//Console.WriteLine("digite uma palavra com numeros");
//string palavraComNumerais = Console.ReadLine();

//string[] numerais = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
//string[] numeraisExtenso = { "zero","um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };

////eu tenho 9 gatos e 1 cachorro

//for(int i = 0; i < numerais.Length; i++)
//{
//    palavraComNumerais = palavraComNumerais.Replace(numerais[i], numeraisExtenso[i]);
//}

//Console.WriteLine(palavraComNumerais);


//bom.. é só pra trocar http por https, esse eu nem vou explicar

//Console.WriteLine("digite uma url com http");
//string urlErrada = Console.ReadLine();

//string urlCorreta = urlErrada.Replace("http", "https");

//Console.WriteLine(urlCorreta);

//Nesse exercicio, devemos retirar todos os acentos das letras
//infelizmente não consegui pensar numa forma mais inteligente de fazer isso
//pelo menos não com o que tenho de aprendizado até o momento
//ele utiliza a mesma lógica do exercicio anterior

Console.WriteLine("digite palavras com acentos");
string acentuado = Console.ReadLine();

//amanhã todos nós iremos comer pão

string[] acentos = { "á", "ã", "à", "â", "é", "è", "ê", "í", "ì", "î", "ó", "õ", "ò", "ô", "ú", "ù", "û" };
string[] semAcentos = { "a", "a ", "a", "a", "e", "e", "e", "i", "i", "i", "o", "o", "o", "o", "u", "u", "u" };

for (int i = 0; i < acentos.Length; i++)
{
    acentuado = acentuado.Replace(acentos[i], semAcentos[i]);
}

Console.WriteLine(acentuado);



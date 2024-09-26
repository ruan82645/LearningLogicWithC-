// Metodo ToCharArray(). Tem um propósito simples e fácil de entender
// Ele é usado como o proprio nome diz para converter uma string em um array de caracteres
// diferente do Split() que usamos para dividir palavra por palavra
// aqui tudo será separado dentro do array, usando o mesmo método de split
// criando um array armazenando a string que queremos .ToCharArray()
// Assim podemos trata-lá de alguma forma
// só lembrando que ao abrir o array, devemos usar "char[] 'nome' = 'exemplo'.ToCharArray()"

// Charles informou que não é muito utilizada, mas que devo saber sobre essa separação
// afinal, em algum momento isso pode ser útil

string Exemplo1 = "ruan";
char[] CharArray = Exemplo1.ToCharArray();
//[r,u,a,n]

//não tenho muito mais o que usar de explicação, então vamos aos exercicios


//1) devemos inverter uma palavra usando o ToCharArray();

//Console.WriteLine("digite uma palavra para ser invertida");
//string palavra = Console.ReadLine();

//char[] ArrayDeChar = palavra.ToCharArray();

//string inverso = "";
////ruan
////0123
//for (int i = ArrayDeChar.Length; i > 0; i--)
//{
//    inverso += ArrayDeChar[i-1];
//}

//Console.WriteLine(inverso);

//2) Nesse exercicio, devemos contar a quantidade de vogais e consoantes na string

//while (true)
//{
//    Console.WriteLine("digite alguma coisa");
//    string palavraComVogal = Console.ReadLine();
//    int contadorVogal = 0;
//    int contadorConsoante = 0;
//    char[] Chares = palavraComVogal.ToCharArray();
//    char[] vogais = new char[] { 'a', 'e', 'i', 'o', 'u' };
//    char[] consoante = new char[] { 'b', 'c', 'd', 'f', 'g', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };

//    for (int i = 0; i < Chares.Length; i++)
//    {
//        for (int j = 0; j < vogais.Length; j++)
//        {
//            if (Chares[i] == vogais[j])
//            {
//                contadorVogal++;
//            }
//        }
//    }
//    for (int i = 0; i < Chares.Length; i++)
//    {
//        for (int j = 0; j < consoante.Length; j++)
//        {
//            if (Chares[i] == consoante[j])
//            {
//                contadorConsoante++;
//            }
//        }
//    }

//    Console.WriteLine("numero de vogais: " + contadorVogal);
//    Console.WriteLine("numero de consoantes: " + contadorConsoante);
//}

//3) verificar se a palavra é escrita da mesma forma de trás para frente

Console.WriteLine("digite uma palavra");
string texto = Console.ReadLine();
//ama
//123
//
//

char[] ArrayDeLetras = texto.ToCharArray();
int contador = 0;

for(int i = 0; i<ArrayDeLetras.Length; i++)
{
    for(int j = ArrayDeLetras.Length; j > 0; j--)
    {
        if (ArrayDeLetras[i] == ArrayDeLetras[j-1])
        {
            contador++;
            Console.WriteLine(ArrayDeLetras[i] + " " + ArrayDeLetras[j]);
        }
    }
}

if(contador == ArrayDeLetras.Length)
{
    Console.WriteLine("palindromo");
}
else
{
    Console.WriteLine("não é palindromo");
}



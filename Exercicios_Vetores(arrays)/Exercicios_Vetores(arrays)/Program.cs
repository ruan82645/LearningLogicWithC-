/*Crie um programa que leia N números digitados e armazene num array(vetor)
 * e sem seguida, mostre todos os número negativos digitados*/

Console.WriteLine("Escreva quantos números quer que estejam no seu array");
int qntnumeros = int.Parse(Console.ReadLine());

int[] numeros = new int[qntnumeros];

int i = 0;

for( i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("digite um número que queira colocar dentro do array");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (i = 0; i < numeros.Length; i++)
{
    if (numeros[i] < 0)
    {
        Console.WriteLine("Esses são número negativos:");
        Console.WriteLine(numeros[i]);
    }
}
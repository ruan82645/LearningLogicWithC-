
int[] b = { 1, 2, 3, 4, 5, 6, 7 };

int comprimento = b.Length;
int valorInicial = 0;
int valorIndexFinal = b.Length - 1;

for( int i =0; i < b.Length; i++)
{
    Console.WriteLine(b[i]);
}

while (true)
{

    Console.WriteLine("digite um index para saber o resultado");
    int index = int.Parse(Console.ReadLine());


    if (index > valorInicial && index < valorIndexFinal)
    {
        Console.WriteLine("o valor contido em b["+ index +"] é: " + b[index] );
    }
    else
    {
        Console.WriteLine("valor invalido");
    }
}
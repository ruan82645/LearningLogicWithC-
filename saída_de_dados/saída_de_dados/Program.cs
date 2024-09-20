
int[] a = new int[5];

a[0] = 1;
a[1] = 2;
a[2] = 3;
a[3] = 4;
a[4] = 5;

int comprimento = a.Length;
int valorInicial = 0;
int valorIndexFinal = a.Length - 1;

for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine(a[i]);
}
Console.WriteLine();
Console.WriteLine(comprimento);
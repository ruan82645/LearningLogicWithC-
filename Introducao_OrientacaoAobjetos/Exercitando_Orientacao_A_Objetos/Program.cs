

using Exercitando_Orientacao_A_Objetos;
using System;

int exercicio = 0;

while(exercicio < 1 || exercicio > 4)
{
    Console.WriteLine("Qual exercicio quer acessar? Escolha entre 1 - 4");
    exercicio = int.Parse(Console.ReadLine());

}

if(exercicio == 1)

{
    Circulo circulo1 = new Circulo();
    Circulo circulo2 = new Circulo();
    Circulo circulo3 = new Circulo();

    Console.WriteLine("por favor, informe o raio do circulo 1 para que a circunferencia seja calculada");
    circulo1.Raio = double.Parse(Console.ReadLine());
    Console.WriteLine("qual a cor do seu circulo?");
    circulo1.Color = Console.ReadLine();

    Console.WriteLine("por favor, informe o raio do circulo 2 para que a circunferencia seja calculada");
    circulo2.Raio = double.Parse(Console.ReadLine());
    Console.WriteLine("qual a cor do seu circulo?");
    circulo2.Color = Console.ReadLine();

    Console.WriteLine("por favor, informe o raio do circulo 3 para que a circunferencia seja calculada");
    circulo3.Raio = double.Parse(Console.ReadLine());
    Console.WriteLine("qual a cor do seu circulo?");
    circulo3.Color = Console.ReadLine();

    Console.WriteLine("a cisrcunferencia do circulo 1 é de " + circulo1.Circunferencia() + " centimentros, e a cor dele é " + circulo1.Color);
    Console.WriteLine("a cisrcunferencia do circulo 2 é de " + circulo2.Circunferencia() + " centimentros, e a cor dele é " + circulo2.Color);
    Console.WriteLine("a cisrcunferencia do circulo 2 é de " + circulo3.Circunferencia() + " centimentros, e a cor dele é " + circulo3.Color);

}

if(exercicio == 2)
{
    Triangulo triangulo1 = new Triangulo();
    Triangulo triangulo2 = new Triangulo();
    Triangulo triangulo3 = new Triangulo();

    Console.WriteLine("por favor, me informe a base e altura do triangulo 1 para calcularmos a área");
    triangulo1.Largura = double.Parse(Console.ReadLine());
    triangulo1.Altura = double.Parse(Console.ReadLine());
    Console.WriteLine("qual o tipo do seu triangulo?");
    triangulo1.tipo = Console.ReadLine();

    Console.WriteLine("por favor, me informe a base e altura do triangulo 2 para calcularmos a área");
    triangulo2.Largura = double.Parse(Console.ReadLine());
    triangulo2.Altura = double.Parse(Console.ReadLine());
    Console.WriteLine("qual o tipo do seu triangulo?");
    triangulo2.tipo = Console.ReadLine();

    Console.WriteLine("por favor, me informe a base e altura do triangulo 3 para calcularmos a área");
    triangulo3.Largura = double.Parse(Console.ReadLine());
    triangulo3.Altura = double.Parse(Console.ReadLine());
    Console.WriteLine("qual o tipo do seu triangulo?");
    triangulo3.tipo = Console.ReadLine();

    Console.WriteLine();
    Console.WriteLine("Pronto, tudo calculado");
    Console.WriteLine();
    Console.WriteLine("a área do triangulo 1 é de " + triangulo1.AreaTriangulo() + " e o tipo dele seria " + triangulo1.tipo);
    Console.WriteLine("a área do triangulo 2 é de " + triangulo2.AreaTriangulo() + " e o tipo dele seria " + triangulo2.tipo);
    Console.WriteLine("a área do triangulo 3 é de " + triangulo3.AreaTriangulo() + " e o tipo dele seria " + triangulo3.tipo);

}

if (exercicio == 3)
{
    Cubo cubo1 = new Cubo();
    Cubo cubo2 = new Cubo();
    Cubo cubo3 = new Cubo();

    Console.WriteLine("por favor, diga o tamanho do lado do cubo 1 para que seu volume seja calculado");
    cubo1.lado = double.Parse(Console.ReadLine());
    Console.WriteLine("por favor, diga o tamanho do lado do cubo 2 para que seu volume seja calculado");
    cubo2.lado = double.Parse(Console.ReadLine());
    Console.WriteLine("por favor, diga o tamanho do lado do cubo 3 para que seu volume seja calculado");
    cubo3.lado = double.Parse(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine("Pronto, tudo calculado");
    Console.WriteLine();
    Console.WriteLine("o volume do cubo 1 é de " + cubo1.Volume());
    Console.WriteLine("o volume do cubo 2 é de " + cubo2.Volume());
    Console.WriteLine("o volume do cubo 3 é de " + cubo3.Volume());
}
if (exercicio == 4)
{
    Pessoa pessoa1 = new Pessoa();
    Pessoa pessoa2 = new Pessoa();
    Pessoa pessoa3 = new Pessoa();

    Console.WriteLine("me diga as informações basicas da pessoa que quer criar");
    pessoa1.nome = Console.ReadLine();
    pessoa1.idade = int.Parse(Console.ReadLine());
    pessoa1.altura = double.Parse(Console.ReadLine());

    Console.WriteLine("me diga as informações basicas da pessoa que quer criar");
    pessoa2.nome = Console.ReadLine();
    pessoa2.idade = int.Parse(Console.ReadLine());
    pessoa2.altura = double.Parse(Console.ReadLine());

    Console.WriteLine("me diga as informações basicas da pessoa que quer criar");
    pessoa3.nome = Console.ReadLine();
    pessoa3.idade = int.Parse(Console.ReadLine());
    pessoa3.altura = double.Parse(Console.ReadLine());

    Console.WriteLine(pessoa1.Info());
    Console.WriteLine(pessoa2.Info());
    Console.WriteLine(pessoa3.Info());


}


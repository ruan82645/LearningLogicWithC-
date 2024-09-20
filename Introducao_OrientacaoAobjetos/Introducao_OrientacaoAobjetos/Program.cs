/*vamos calcular a área de um retangulo de forma estrutural, uma abaixo da outra, de forma simples
 Lembrando que esse tipo de "função"(classe) só vai ser executada aqui e não pode ser chamada em outro lugar*/


// para calcular a área de um retangulo, basta saber a altura e largura, então multiplicar elas

using Introducao_OrientacaoAobjetos;

Retangulo retangulo1 = new Retangulo();
Retangulo retangulo2 = new Retangulo();
Retangulo retangulo3 = new Retangulo();

//retangulo 1

Console.WriteLine("Digite a base em cm do retangulo 1");
retangulo1.largura = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a altura do retangulo 1");
retangulo1.altura = double.Parse(Console.ReadLine());

//retangulo 2

Console.WriteLine("Digite a base em cm do retangulo 2");
retangulo2.largura = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a altura em cm do retangulo 1");
retangulo2.altura = double.Parse(Console.ReadLine());

//retangulo 3

Console.WriteLine("Digite a base em cm do retangulo 3");
retangulo3.largura = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a altura em cm do retangulo 3");
retangulo3.altura = double.Parse(Console.ReadLine());

Console.WriteLine("a área do retangulo 1 é de " + retangulo1.CalcularArea() + " cm cubicos");
Console.WriteLine("a área do retangulo 2 é de " + retangulo2.CalcularArea() + " cm cubicos");
Console.WriteLine("a área do retangulo 3 é de " + retangulo3.CalcularArea() + " cm cubicos");



////retangulo 1

//Console.WriteLine("Digite a base em cm do retangulo 1");
//double baseRetangulo1 = double.Parse(Console.ReadLine());

//Console.WriteLine("Digite a altura do retangulo 1");
//double alturaRetangulo1 = double.Parse(Console.ReadLine());

////retangulo 2

//Console.WriteLine("Digite a base em cm do retangulo 2");
//double baseRetangulo2 = double.Parse(Console.ReadLine());

//Console.WriteLine("Digite a altura em cm do retangulo 1");
//double alturaRetangulo2 = double.Parse(Console.ReadLine());

////retangulo 3

//Console.WriteLine("Digite a base em cm do retangulo 3");
//double baseRetangulo3 = double.Parse(Console.ReadLine());

//Console.WriteLine("Digite a altura em cm do retangulo 3");
//double alturaRetangulo3 = double.Parse(Console.ReadLine());

//double areaRetangulo1 = baseRetangulo1 * alturaRetangulo1;
//double areaRetangulo2 = baseRetangulo2 * alturaRetangulo2;
//double areaRetangulo3 = baseRetangulo3 * alturaRetangulo3;

//Console.WriteLine("a área do retangulo 1 é de " + areaRetangulo1 + " cm cubicos");
//Console.WriteLine("a área do retangulo 2 é de " + areaRetangulo2 + " cm cubicos");
//Console.WriteLine("a área do retangulo 3 é de " + areaRetangulo3 + " cm cubicos");
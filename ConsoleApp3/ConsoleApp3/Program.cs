using ConsoleApp3;

//aqui pedimos os valores ao usuario e passamos para dentro do parametro da classe
//como lá dentro do metodo, já especificamos um valor, se não for colocado nada..
//aquele valor será assumido, mas se quisermos mudar, podemos apenas trocar o valor

carro carro = new carro();

Console.WriteLine("por favor, informe o quão a mais vc acelerou depois de 60km/h");
int Vlm = int.Parse(Console.ReadLine());

Console.WriteLine("por favor, informe a potencia do turbo");
int Vlt = int.Parse(Console.ReadLine());

Console.WriteLine("por favor, informe a potencia do nitro");
int Vln = int.Parse(Console.ReadLine());

carro.acelerar(Vlm,Vlt,Vln);
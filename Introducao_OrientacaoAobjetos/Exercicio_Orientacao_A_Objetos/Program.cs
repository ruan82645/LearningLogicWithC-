/*Crie um programa para pedir o nome do funcionário e salário
  Crie uma classe FUNCIONARIO para receber essas informações
  Crie um método na classe para calcular as férias do funcionário ( sálariio * 1.3)*/


using Exercicio_Orientacao_A_Objetos;
using System.Linq.Expressions;

FUNCIONARIO funcionario1 = new FUNCIONARIO();

Console.WriteLine("digite seu nome");
funcionario1.nome = Console.ReadLine();

Console.WriteLine("Digite seu salário");
try{
    funcionario1.Salario = decimal.Parse(Console.ReadLine());
    Console.WriteLine(funcionario1.Ferias());
}
catch(Exception erro){
    Console.WriteLine(erro.Message);
}

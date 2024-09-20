using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MaisExercicios
{
    internal class saudacao
    {
        public void saudar(string nome, string dia = "Bom dia")
        {
            Console.WriteLine(dia + ", " + nome + "!");
        }
    }


    internal class CalcularArea
    {
        public int total = 0;

        public int Area(int largura, int? altura = null)
        {
            if (altura == null)
            {
                altura = largura;
            }

            total = largura * altura.Value;
            Console.WriteLine(total);

            return total;



        }

    }

    internal class Calcular
    {
        public int total = 0;
        public void calculadora(int n1, int n2, string operacao = "+")
        {

            switch (operacao)
            {
                case "+":
                    total = n1 + n2;
                    Console.WriteLine(total.ToString());
                    break;
                case "*":
                    total = n1 * n2;
                    Console.WriteLine(total.ToString());
                    break;
                case "-":
                    total = n1 - n2;
                    Console.WriteLine(total.ToString());
                    break;
                case "/":
                    total = n1 / n2;
                    Console.WriteLine(total.ToString());
                    break;


            }

        }
    }

    internal class FormatarTexto
    {
        public void CaseUpper(string texto, bool upper = true)
        {
            if (upper)
            {
                Console.WriteLine(texto.ToUpper());
            }
            else
            {
                Console.WriteLine(texto.ToLower());
            }


        }


    }

    internal class PedirInformacao
    {

        public string cidade { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }

        public void Info(bool cidadeBool = false)
        {
            if (cidadeBool)
            {
                Console.WriteLine("Informe seu nome");
                nome = Console.ReadLine();
                Console.WriteLine("Informe sua idade");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a sua cidade");
                cidade = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine($"Seu nome é {nome}, tem {idade} anos de idade e mora em {cidade}");

            }
            else
            {
                Console.WriteLine("Informe seu nome");
                nome = Console.ReadLine();
                Console.WriteLine("Informe sua idade");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine($"Seu nome é {nome}, tem {idade} anos de idade");
            }
        }
    }

    public class Temperatura
    {

        public decimal celsius { get; set; }
        public decimal fahrenheit { get; set; }

        public decimal total { get; set; }


        public decimal CelsiusToFah(decimal graus, string tipo = "C")
        {
            if (tipo == "F")
            {
                fahrenheit = (graus * 9 / 5) + 32;
                total = fahrenheit;
                Console.WriteLine($"{graus} celsius convertidos para Fahrenheit, dá: {total.ToString("F2")}°");
            }
            else
            {

                celsius = (graus - 32) * 5 / 9;
                total = celsius;
                Console.WriteLine($"{graus} fahrenheit convertidos para Celsius, dá: {total.ToString("F2")}°");

            }

            return total;

        }

    }
}
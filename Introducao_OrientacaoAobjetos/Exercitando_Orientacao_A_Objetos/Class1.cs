using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitando_Orientacao_A_Objetos

{
    public class Circulo
    {
        public string Color {  get; set; }
        public double Raio { get; set; }

        public double Circunferencia()
        {
           return 2 * 3.14 * Raio;
        }
    }

    public class Triangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }
        public string tipo { get; set; }

        public double AreaTriangulo()
        {
            return Altura * Largura / 2;
        }
     }

    public class Cubo
    {
        public double lado { get; set; }

        public double Volume()
        {
            return lado * lado * lado;
        }
    }

    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public double altura { get; set; }

        public string Info()
        {
            return "nome : " + nome + ", idade : " + idade + ", altura: " + altura + "cm"; 
                    
        }

    }

}

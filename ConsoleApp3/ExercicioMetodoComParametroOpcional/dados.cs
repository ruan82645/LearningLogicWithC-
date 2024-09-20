using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMetodoComParametroOpcional
{
    internal class dados
    {
        static void Dates()
        {

            string nome = ObterDados("informe seu nome");
            string idade = ObterDados("informe sua idade");
            string cidade = ObterDados("informe sua cidade");
            string cachorro = ObterDados();

            Console.WriteLine("seu nome é " + nome);
            Console.WriteLine("sua idade é " + idade);
            Console.WriteLine("sua cidade é " + cidade);
            Console.WriteLine("seu cachorro é " + cachorro);  


        }

        static string ObterDados(string texto = "informe seu texto:")
        {
            Console.WriteLine(texto + ": ");
            return Console.ReadLine();
        }
    }
}
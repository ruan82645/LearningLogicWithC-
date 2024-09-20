using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class ParamsExercicio
    {
        public void ListaNomes()
        {

            ExibirNomes("ronaldo", "jefferson", "ruan", "antonio", "josé");
        }

        public void ExibirNomes(params string[] nomes) {

            foreach (string s in nomes) { 
            Console.WriteLine(s);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_04
{
    internal class Tempo
    {
        public int Segundos()
        {
            string milesimos = Console.ReadLine();

            string segundosString = milesimos + "000";
            int segundosEmMilesimo;

            if (int.TryParse(segundosString, out segundosEmMilesimo))
            {
                return segundosEmMilesimo;
            }
            else
            {
                return Segundos();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColocandoPropriedadesEmAtributos
{
    internal class pato
    {
        public int asas;
        public int Asas
        {
            get { return asas; }
            set
            {
                if (value < 3)
                {
                    asas = value;
                }
                else
                {
                    throw new ArgumentException("seu pato é deficiente");
                }

            }
        }


        public string name { get; set; }
        public string cor { get; set; }

        public void Quack()
        {
            Console.WriteLine("Quack do pato " + name + " " + cor + " com " + asas + " asas.");
        }
        public void QuackError()
        {
            Console.WriteLine("Quack do pato " + name + " " + cor + " com " + asas + " asas perfeitamente normais, seu doente.");
        }
    }
}

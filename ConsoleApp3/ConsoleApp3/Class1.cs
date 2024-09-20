using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class carro
    {
        public int velocidadePadrao = 60;
        public int velocidadeTotal;

        public void acelerar(int velocidadeAmais = 10, int velocidadeDoTurbo = 1, int velocidadeDoNitro = 1)
        {
            velocidadeTotal = velocidadePadrao + velocidadeAmais * velocidadeDoNitro * velocidadeDoTurbo * 2;

            Console.WriteLine("velocidade total é igual a: " + velocidadeTotal);
        }
    }
}

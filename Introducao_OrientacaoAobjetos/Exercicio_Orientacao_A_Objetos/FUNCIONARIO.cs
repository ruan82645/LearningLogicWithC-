using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Orientacao_A_Objetos
{
    internal class FUNCIONARIO
    {
        public string nome { get; set; }
        public decimal salario;
        public decimal Salario
        {
            get { return salario; }
            set
            {
                if (value < 1350)
                {
                    throw new ArgumentException("informe o sálário correto");
                }
                salario = value;
            }

        }
        public decimal Ferias()
        {
            return Salario * 1.3m;
        }
    }
}    

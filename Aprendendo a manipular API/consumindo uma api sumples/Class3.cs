using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumindo_uma_api_sumples
{
    internal class imprecao
    {
        public void exibirDados(Endereco endereco)
        {
            Console.WriteLine($"CEP: {endereco.Cep}");
            Console.WriteLine($"Logradouro: {endereco.Logradouro}");
            Console.WriteLine($"Complemento: {endereco.Complemento}");
            Console.WriteLine($"Bairro: {endereco.Bairro}");
            Console.WriteLine($"Localidade: {endereco.Localidade}");
            Console.WriteLine($"UF: {endereco.Uf}");
            Console.WriteLine($"IBGE: {endereco.Ibge}");
            Console.WriteLine($"GIA: {endereco.Gia}");
            Console.WriteLine($"DDD: {endereco.Ddd}");
            Console.WriteLine($"SIAFI: {endereco.Siafi}");
        }
    }
}

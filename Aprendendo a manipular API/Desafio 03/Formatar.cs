using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_03
{
    internal class Formatar
    {
        public void Exibir(Infos popularMovies)
        {
            Console.WriteLine($"Página: {popularMovies.Page}");
            Console.WriteLine("Filmes Populares:");
            Console.WriteLine();
            
            foreach (var filme in popularMovies.Results)
            {
                Console.WriteLine($"Título: {filme.Title}");
                Console.WriteLine($"Data de Lançamento: {filme.ReleaseDate:dd/MM/yyyy}");
                Console.WriteLine($"Média de Avaliação: {filme.VoteAverage}");
                Console.WriteLine(new string('-', 30));
            }
        }
    } 
}


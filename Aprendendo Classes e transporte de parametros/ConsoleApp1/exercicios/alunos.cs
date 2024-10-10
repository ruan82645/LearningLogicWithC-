using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Alunos.gerenciar;

namespace Alunos
{

    public class verificacaoNota
    {
        public decimal Verificacao(string nota)
        {
            while (true)
            {
                decimal notaReal;
                bool sucessoNota = decimal.TryParse(nota, out notaReal);

                if (sucessoNota)
                {
                    decimal notaArredondada = Math.Round(notaReal, 2);
                    return notaArredondada;
                }
                else
                {
                    Console.WriteLine("nota em formato incorreto");
                }
            }

        }
    }

    public class gerenciar
    {
        public class dados
        {
            public string nome { get; set; }
            public int matricula { get; set; }
            public decimal[] notas { get; set; }
            public decimal media { get; set; }

        }

        public class adicionar
        {
            public List<dados> AdicionarAluno(string nome, int matricula, decimal[] notas, List<dados> dados)
            {

                dados aluno = new dados();

                aluno.nome = nome;
                aluno.matricula = matricula;
                aluno.notas = notas;

                dados.Add(aluno);
                return dados;

            }
        }

        public class calcular
        {
            public void CalcularMedia(List<dados> dados)
            {
                foreach (var aluno in dados)
                {
                    decimal SomaNotas = 0;

                    foreach (var nota in aluno.notas)
                    {
                        SomaNotas += nota;
                    }

                    decimal media = SomaNotas / aluno.notas.Length;

                    aluno.media = media;
                }
            }
        }

        public class exibir
        {
            public void ExibirEmConsole(List<dados> dados)
            {
                foreach(var aluno in dados)
                {
                    Console.WriteLine($"nome:{aluno.nome}, matricula:{aluno.matricula}, media{aluno.media}");
                }
            }

        }
    }
}




    public class Program
    {
        static void Main(string[] args)
        {
            var gerenciador = new Gerenciador();
            gerenciador.Iniciar();
        }
    }



    public class Gerenciador
    {
        private List<Dados> alunos = new List<Dados>();
        private VerificacaoNota verificacao = new VerificacaoNota();

        public void Iniciar()
        {
            while (true)
            {
                AdicionarAluno();

                Console.WriteLine("Deseja adicionar mais um aluno? (sim/não)");
                string confirmar = Console.ReadLine().ToLower();

                if (confirmar != "sim") break;
            }

            CalcularMedia();
            ExibirResultados();
        }

        private void AdicionarAluno()
        {
            Console.WriteLine("Por favor, informe o nome do aluno:");
            string nome = Console.ReadLine();

            Console.WriteLine("Por favor, informe a matrícula do aluno (6 dígitos):");
            string matriculaInput = Console.ReadLine();
            int matricula = ValidarMatricula(matriculaInput);

            decimal[] notas = new decimal[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Por favor, informe a {i + 1}ª nota do aluno:");
                notas[i] = verificacao.Verificacao(Console.ReadLine());
            }

            alunos.Add(new Dados { Nome = nome, Matricula = matricula, Notas = notas });
            Console.WriteLine("Aluno adicionado.\n");
        }

        private int ValidarMatricula(string matriculaInput)
        {
            if (matriculaInput.Length == 6 && int.TryParse(matriculaInput, out int matricula))
            {
                return matricula;
            }
            else
            {
                Console.WriteLine("A matrícula deve conter 6 dígitos numéricos.");
                return ValidarMatricula(Console.ReadLine());
            }
        }

        private void CalcularMedia()
        {
            foreach (var aluno in alunos)
            {
                decimal somaNotas = 0;
                foreach (var nota in aluno.Notas)
                {
                    somaNotas += nota;
                }
                aluno.Media = somaNotas / aluno.Notas.Length;
            }
        }

        private void ExibirResultados()
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, Matrícula: {aluno.Matricula}, Média: {aluno.Media:F2}");
            }
        }
    }

    public class Dados
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public decimal[] Notas { get; set; }
        public decimal Media { get; set; }
    }

    public class VerificacaoNota
    {
        public decimal Verificacao(string nota)
        {
            while (true)
            {
                if (decimal.TryParse(nota, out decimal notaReal) && notaReal >= 0 && notaReal <= 10)
                {
                    return Math.Round(notaReal, 2);
                }
                else
                {
                    Console.WriteLine("Nota em formato incorreto ou fora do intervalo (0 a 10). Tente novamente:");
                    nota = Console.ReadLine();
                }
            }
        }
    }

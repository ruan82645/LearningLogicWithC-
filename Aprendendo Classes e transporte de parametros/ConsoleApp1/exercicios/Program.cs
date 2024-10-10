

// para fixar bem, não há outro jeito, tem que ser exercitando ao máximo
// isso vai ajudar no conceito de paramatros, props, etc

//1) Criar um programa onde serão informados dados de alunos, como nome, matricula e média de notas(lista de 4 notas)
// o programa principal deve pedir essas informações, para serem passadas para as classes.
// Deve ter uma classe onde armazena dados, adicionar os alunos, calcular média e exibir as informações
// foram criadas verificacoes para as notas também em um classe separada

using Alunos;
using static Alunos.gerenciar;

verificacaoNota verificar = new verificacaoNota();
adicionar listaAlunos = new adicionar();
calcular media = new calcular();
exibir exibir = new exibir();
List<dados> dadosDosAlunos = new List<dados>();

string nome;
int matriculaReal;
decimal[] notas;
List<dados> listaDeAlunos;

while (true)
{
    while (true)
    {
        Console.WriteLine("por favor, informe o nome do aluno");
        nome = Console.ReadLine();

        if (nome != null)
        {
            break;
        }
    }
    while (true)
    {
        Console.WriteLine("por favor, informe a matricula do aluno (6 digitos)");
        string matricula = Console.ReadLine();
        bool sucesso = int.TryParse(matricula, out matriculaReal);

        if (sucesso)
        {
            if (matricula.Length != 6)
            {
                Console.WriteLine("a matricula deve conter 6 digitos");
            }
            else
            {
                break;
            }
        }
        else
        {
            Console.WriteLine("dados informados ser 6 numeros");
        }
    }

    Console.WriteLine("por favor, informe a primeira nota do aluno");
    string nota1 = Console.ReadLine();
    decimal notaReal1 = verificar.Verificacao(nota1);

    Console.WriteLine("por favor, informe a segunda nota do aluno");
    string nota2 = Console.ReadLine();
    decimal notaReal2 = verificar.Verificacao(nota2);

    Console.WriteLine("por favor, informe a terceira nota do aluno");
    string nota3 = Console.ReadLine();
    decimal notaReal3 = verificar.Verificacao(nota3);

    Console.WriteLine("por favor, informe a quarta nota do aluno");
    string nota4 = Console.ReadLine();
    decimal notaReal4 = verificar.Verificacao(nota4);

    notas = new decimal[] {notaReal1, notaReal2, notaReal3, notaReal4 };

    Console.WriteLine("aluno adicionado\n");

    Console.WriteLine("deseja adicionar mais aluno? sim ou não?");
    string confirmar;
    while (true)
    {
       confirmar = Console.ReadLine();

        if (confirmar.ToLower() == "sim" || confirmar.ToLower() == "não")
        {
            if (confirmar == "sim")
            {
                break;
            }
            else
            {
                Console.WriteLine();
                break;
            }
            
        }
        else
        {
            Console.WriteLine("digite corretamente");
        }
    }

    listaDeAlunos = listaAlunos.AdicionarAluno(nome, matriculaReal, notas, dadosDosAlunos);

    if (confirmar == "não")
    {
        break;
    }
}
media.CalcularMedia(listaDeAlunos);
exibir.ExibirEmConsole(listaDeAlunos);





    


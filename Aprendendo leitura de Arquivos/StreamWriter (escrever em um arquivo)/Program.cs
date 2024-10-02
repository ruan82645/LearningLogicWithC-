// WRITER

// StreamWriter é simples de entender. Ele pode tanto criar um arquivo como escrever em um arquivo
// então podemos editar adicionando algo em um arquivo que já existe ou criar e editar o mesmo
// Quando declaramos a variavel StreamWriter, ao colocar o caminho do arquivo, também podemos adicionar um true ou false
// esse bool significa se ele toda vez que repetir o programa ele vai escrever a mais do que já estava,
// ou se ele vai substituir o que estava escrito por algo novo
// como assim? False significa, apagar e reescrever. Enquanto True é adicionar e adicionar todas as vezes que o programa iniciar

using System.Data;
using System.Text;

System.IO.StreamWriter substituidor = new System.IO.StreamWriter("texto1", false);

System.IO.StreamWriter adicionador = new System.IO.StreamWriter("texto2", true);

// Quando arquivo não existe, ele mesmo cria e podemos escrever dentro,
// quando já existe, ele escreve dentro do que já existe

// Agora como fazemos para escrever? Assim como o StreamReader permite o .ReadLine() na variavel que armazena um valor Stream,
// o StreamWriter permite que sua variavel receba o .WriteLine() para escrever em cada linha

System.IO.StreamWriter Exemplo1 = new System.IO.StreamWriter("texto3", false);

Exemplo1.WriteLine("linha 1");
Exemplo1.WriteLine("linha 2");
Exemplo1.WriteLine("linha 3");

// Aqui em cima, escrevemos 3 linhas dentro do arquivo "texto3.txt".
// Caso queira, também podemos gerar loops para escrever por nós, dessa forma

System.IO.StreamWriter Exemplo2 = new System.IO.StreamWriter("texto4", false);

for (int i = 0; i < 10; i++)
{
    Exemplo2.WriteLine("linha " + i);
}


//Não creio que tenha muito mais o que explicar, então vamos aos exercicios

//1) Nesse exercicio, o usuario deve informar duas datas.
//então devemos escrever em um arquivo, todas as datas entre as referencias nesse arquivo

//Console.WriteLine("informe uma data");
//DateTime inicial = DateTime.Parse(Console.ReadLine());
//Console.WriteLine("informe uma data");
//DateTime final = DateTime.Parse(Console.ReadLine());

//DateTime atual = inicial.AddDays(1);

//System.IO.StreamWriter datas = new System.IO.StreamWriter("datas1.txt", false);

//while (atual != final)
//{
//    datas.WriteLine(atual.ToString("dd/MM/yyyy"));
//    atual = atual.AddDays(1);
//}
//datas.Close();

//2) aqui, o programa vai pedir entradas sem parar para o usuario e ir escrevendo cada coisa no arquivo
// quando digitar "sair", o prgrama deve ser finalizado

//System.IO.StreamWriter documento = new System.IO.StreamWriter("escrita.txt", false);

//Console.WriteLine("digite palavras");
//while (true)
//{
//    string info = Console.ReadLine();
//    if (info.ToLower() == "sair")
//    {
//        break;
//    }
//    documento.WriteLine(info);
//}
//Console.WriteLine("documento pronto");

//3) Nesse exercicio, devemos pesquisar um termo em varios arquivos dentro de uma pasta, dizer em qual arquivo está
// e trazer a linha que está escrita esse termo

string[] arquivos = System.IO.Directory.GetFiles("C:\\Users\\ruanp\\source\\repos\\pesquisaStreamReader");

Console.WriteLine("o que deseja pesquisar?");
string pesquisa = Console.ReadLine();

int encontrado = 0;

while (true)
{
    for (int i = 0; i < arquivos.Length; i++)
    {
        string nomeArquivo = Path.GetFileName(arquivos[i]);
        System.IO.StreamReader buscador = new System.IO.StreamReader($"C:\\Users\\ruanp\\source\\repos\\pesquisaStreamReader\\{nomeArquivo}");

        int contadorLinha = 0;
        while (!buscador.EndOfStream)
        {
            contadorLinha++;

            string linha = buscador.ReadLine();
            if (linha.Contains(pesquisa))
            {
                encontrado++;
                Console.WriteLine($"termo encontrado no arquivo: {nomeArquivo}");
                Console.WriteLine($"na linha {contadorLinha}");
            }

        }
    }
    break;
}
if (encontrado == 0)
{
    Console.WriteLine("termo não encontrado nos arquivos");
}

////4) Nesse exercicio, devemos copiar o que está em um arquivo e passar para outro

//System.IO.StreamReader leitor = new System.IO.StreamReader("leitor.txt");
//System.IO.StreamWriter escritor = new System.IO.StreamWriter("leitor.txt", false);


//while (!leitor.EndOfStream)
//{
//    string linha = leitor.ReadLine();
//    escritor.WriteLine(linha);
//}

//5) Nesse exercicio, devemos pegar varios arquivos, ler todos e escrever todo o conteudo deles em um só arquivo separado

string[] geral = System.IO.Directory.GetFiles("C:\\Users\\ruanp\\source\\repos\\pesquisaStreamReader");
System.IO.StreamWriter copiador = new System.IO.StreamWriter("tudojunto.txt");

for (int i = 0; i < geral.Length; i++)
{
    System.IO.StreamReader leitura = new System.IO.StreamReader(geral[i]);

    while (!leitura.EndOfStream)
    {
        string linha = leitura.ReadLine();
        copiador.WriteLine(linha);

    }
    copiador.WriteLine(" ");
}
copiador.Close();

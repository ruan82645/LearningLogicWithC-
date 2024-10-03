{
// O que é o GetFiles()?

// Ele é um método que permite pegar todos os arquivos de uma pasta e armazenar suas informações em um array.
// podendo também filtrar extensões especificas e ou somente arquivos que tenham palavras que queremos.
// Isso facilita o acesso e a manipulação dos arquivos, já que para cada item do array, podemos buscar detalhes como:
// nome, caminho completo, tamanho, data de modificação, entre outros.

// Dependendo com qual das classes usamos ele (DirectoryInfo e Directory), GetFiles() armazena diferentes tipos de informação
// como DirectoryInfo inicia uma variavel propria, ela possui todo tipo de informação de cada arquivo dentro da pasta
// enquanto se chamarmos Directory.GetFiles(), ele somente armazenará seu caminho completo e mais nada 

// Para usa-lo, existem duas maneiras, uma para DirectoryInfo e outra para Directoy.

//--------------------------------------------------------------------------------------------------------------------------

// Directory)

// primeiro, devemos iniciar um array de strings que vai armazenar os caminhos de cada arquivo
// já que Directory é uma classe estática, devemos passar o caminho diretamente dentro do parenteses
   string[] exemplo1 = Directory.GetFiles("C:\\Users\\ruanp\\source\\repos");
// após esse parâmetro, pode ser passado o filtro

// o problema de Directory é ter de usar mais classes e mais métodos,
// nessa string estão os caminhos, mas e se eu quiser pegar somente o nome?

   string nomeArquivoExemplo = Path.GetFileName(exemplo1[0]);

//--------------------------------------------------------------------------------------------------------------------------

// DirectoryInfo)

// Aqui, ele já é usado de forma diferente.
// para chamarmos ele, primeiro abrimos um array FileInfo[], afinal, dentre dele não terá outras pastas, mas arquivos
// e como sua varável já possui o caminho dentro dela, chamamos a variavel.GetFiles
   System.IO.DirectoryInfo diretorio = new System.IO.DirectoryInfo("C:\\Users\\ruanp\\source\\repos");
   FileInfo[] Exemplo2 = diretorio.GetFiles();
// viu? sua variavel já tem o caminho, então não há necessidade de passar por dentro do parenteses
// e dentro dele, podemos colocar o filtro

//--------------------------------------------------------------------------------------------------------------------------

// O GetFiles() também permite usar um filtro opcional, como "*.txt", ou "trabalho"
// *.txt, *.pdf, etc. Armazenam somente os formatos filtrados
// "travesseiro", "garrafa", etc. Armazena os arquivos que tenham essas palavras no titulo.

   FileInfo[] SomenteComPalavraLivro = diretorio.GetFiles("livro");
   //vai armazenar no array somente os arquivos que tiverem "livro" escrito em seu titulo

   FileInfo[] SomentePDF = diretorio.GetFiles("*.pdf");
//vai armazenar no array somente os arquivos pdf
}

// Não tem muito mais o que explicar, vamos para os exercicios então

//1) Nesse exercicio, devemos listar todos os arquivos de uma extensão especifica
// o usuario deve fornecer o diretorio e o formatoi de arquivo que ele quer

//Console.WriteLine("digite o caminho do diretorio");
//string caminho = Console.ReadLine();

//Console.WriteLine("digite qual a extensão que você deseja buscar");
//string extensao = Console.ReadLine();

//extensao = extensao.ToLower();

//if (!(extensao.StartsWith('.')))
//{
//    extensao = $".{extensao}";
//}

//int i = 0;

//string[] arquivos = System.IO.Directory.GetFiles(caminho,$"*{extensao}");
//string nomeArquivo = Path.GetFileName(arquivos[i]);

//if( arquivos.Length == 0)
//{
//    Console.WriteLine($"nenhum arquivo {extensao} encontrado");
//}
//else if ( arquivos.Length == 1)
//{
//    Console.WriteLine("arquivo encontrado\n");
//    Console.WriteLine(arquivos[i]);
//}
//else
//{
//    Console.WriteLine("arquivos encontrados\n");
//    foreach(string arquivo in arquivos)
//    {
//        nomeArquivo = Path.GetFileName(arquivos[i]);
//        Console.WriteLine(nomeArquivo);
//        i++;
//    }
//}

//2) Nesse exercicio, ele deve ler todos os arquivos de texto txt em um diretorio
// e escrever todos eles no console

string[] txtGeral = System.IO.Directory.GetFiles("C:\\Users\\ruanp\\source\\repos\\Aprendendo leitura de Arquivos\\File.Copy (copiar arquivo de um lugar para outro)\\bin\\Debug\\net8.0\\destino copia", "*txt");
int j = 0;
while (j <= txtGeral.Length-1)
{
    
    System.IO.StreamReader leitor = new System.IO.StreamReader(txtGeral[j]);
    string NomeTxt = Path.GetFileNameWithoutExtension(txtGeral[j]);

    Console.WriteLine($"arquivo: {NomeTxt}\n");
    while (!leitor.EndOfStream)
    {
        string linha = leitor.ReadLine();
        Console.WriteLine(linha);
    }
    j++;
}
Console.WriteLine("\nSem mais arquivos para exibir");

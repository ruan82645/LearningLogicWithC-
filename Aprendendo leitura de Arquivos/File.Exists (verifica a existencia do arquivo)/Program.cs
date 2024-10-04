// File.Exists não é dificil de entender, mas demanda um pouquinho de lógica
// Como seu nome diz, ele verifica a existencia do arquivo em um diretório e podemos usar isso para diversas coisas.
// Quando copiamos arquivos por exemplo, se o mesmo nome já existir no diretório de destino, aprensentará erro,
// Para dar um exemplo, com o File.Exists, podemos informar para o programa se ele pode ou não fazer a cópia do arquivo.

using System.Text;

string origem = "C:\\users\\ruanp\\diretorioOrigem\\texto.txt";
string destino = "C:\\users\\ruanp\\texto.txt";

   if (!File.Exists(destino))
    {
        File.Copy(origem, destino);
    }
   // note que ele verificou se texto.txt estava no destino, quando ele viu que não estava, ele copiou
   // destino foi a sua referencia de arquivo, ele tinha um arquivo para verificar se existia ou não

// Lembrando que File.Exists se remete sempre ao arquivo ATUAL que está sendo tratado,
// ele sempre deve estar dentro de algo que tenha como referencia UM arquivo,
// se tiver mais de um para analisar, DEVE estar dentro de um loop, e a cada iteração deve ter um novo arquivo como referencia
// ele não analisa todos os arquivos de um diretório, nem arrays com varios arquivos, somente um arquivo por vez

DirectoryInfo pastaExemplo1 = new DirectoryInfo("C:\\users\\ruanp\\diretorioOrigem");
FileInfo[] arquivosExemplo1 = pastaExemplo1.GetFiles();

    foreach(FileInfo arquivo in arquivosExemplo1)
    {
        if (!File.Exists($"C:\\users\\ruanp\\{arquivo.Name}"))
        {
        File.Move(arquivo.FullName, "C:\\Users\\ruanp\\diretorioDestino");
        }
    }
    // note que a cada iteração, ele verifica se um arquivo igual existe no destino,
    // caso não exista, ele move o arquivo para lá
    // mas entenda que a cada iteração ele tem como referencia um novo arquivo dentro da pasta
    
    // vou dar outro exemplo usando o For com as mesmas informações do exemplo de cima

DirectoryInfo pastaExemplo2 = new DirectoryInfo("C:\\users\\ruanp\\diretorioOrigem");
FileInfo[] arquivosExemplo2 = pastaExemplo2.GetFiles();

    for(int i = 0; i < arquivosExemplo2.Length; i++)
    {
        if (!File.Exists($"C:\\users\\ruanp\\{arquivosExemplo2[i].Name}"))
        {
        File.Move(arquivosExemplo2[i].FullName, "C:\\Users\\ruanp\\diretorioDestino");
        }
    }
    // mesma função utilizando outro loop, para cada iteração, o index muda e o arquivo de referencia é outro



    


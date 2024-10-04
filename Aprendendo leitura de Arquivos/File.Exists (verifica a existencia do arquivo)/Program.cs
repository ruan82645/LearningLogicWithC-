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

DirectoryInfo pasta = new DirectoryInfo("C:\\users\\ruanp\\diretorioOrigem");
FileInfo[] arquivos = pasta.GetFiles();

    foreach(FileInfo arquivo in arquivos)
    {
        if (!File.Exists(destino))
        {
        File.Move(arquivo.FullName, "C:\\Users\\ruanp\\diretorioDestino");
        }
    }
    // note que a cada arquivo, ele verifica no 
    


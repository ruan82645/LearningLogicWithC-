
// 1) Nesse exercicio, vamos copiar somente arquivos de uma certa extensao para uma pasta de origem
// caso um arquivo já exista no destino, não cole e siga para o próximo
// se o diretório não existir, crie ele
//{
//Console.WriteLine("qual a pasta de origem dos arquivos?");
//string origem = Console.ReadLine();
//Console.WriteLine("qual a pasta de destino dos arquivos?");
//string destino = Console.ReadLine();
//Console.WriteLine("qual a extensão do arquivo que você quer copiar?");
//string extensao = Console.ReadLine().ToLower();

//if (!Directory.Exists(destino)) 
//{ 
//    Directory.CreateDirectory(destino);
//}

//if (!extensao.StartsWith('.'))
//{
//    extensao = $".{extensao}";
//}

//int i = 0;

//System.IO.DirectoryInfo pastaOrigem = new System.IO.DirectoryInfo(origem);
//FileInfo[] arquivos = pastaOrigem.GetFiles($"*{extensao}");

//foreach( FileInfo arquivo in arquivos)
//{
//    if (!File.Exists(destino))
//    {
//        System.IO.File.Copy($"{origem}\\{arquivo.Name}", $"{destino}\\{ arquivo.Name}");
//    }
//}
//}
//2) Nesse exercicio, devemos solicitar um diretorio, e dentro dele, o programada deve:
// identificar as extensões que estão lá e criar pastas especificas para cada tipo de arquivo,
// após isso, ele deve mover todos esses arquivos para suas respectivas pastas

//Console.WriteLine("insira um diretório com o caminho completo por favor");
//string caminho = Console.ReadLine();
////T:\downloads

//DirectoryInfo diretorio  = new DirectoryInfo(caminho);
//FileInfo[] arquivos1 = diretorio.GetFiles();

//foreach( FileInfo arquivo in arquivos1)
//{
//    string extensao = Path.GetExtension(arquivo.FullName).ToLower();
//    string extensaoSemPonto = extensao.Replace(".", "");

//    string diretorioPersonalizado = $"{diretorio}\\{extensaoSemPonto}";

//    if (!Directory.Exists(diretorioPersonalizado))
//    {
//        Directory.CreateDirectory(diretorioPersonalizado);
//    }
//    if (!File.Exists(diretorioPersonalizado))
//    {
//        File.Move(arquivo.FullName, diretorioPersonalizado+"\\"+arquivo.Name);
//    }

//}

Console.WriteLine("por favor, insira o link de um site que contenha downloads");
string site = Console.ReadLine();

string htmlSite = new System.Net.WebClient().DownloadString("https://git-scm.com/downloads/win");

int http = 0;
int exe = 0;

    if (htmlSite.Contains("https://") && htmlSite.Contains(".exe"))
    {
        while (htmlSite.IndexOf(".exe") != -1)
        {
            exe = htmlSite.IndexOf(".exe", exe); 
            http = htmlSite.LastIndexOf("https://", exe);

            int numeroDeCaracteres = (exe + 4) - http;

            string linkDownload = htmlSite.Substring(http, numeroDeCaracteres);

            string nomeArquivo = Path.GetFileName(linkDownload);

            new System.Net.WebClient().DownloadFile(linkDownload, nomeArquivo);

            Console.WriteLine($"fazendo download do arquivo {nomeArquivo}");

            http++;
            exe++;
        }
    }


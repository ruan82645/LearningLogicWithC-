
// 1) Nesse exercicio, vamos copiar somente arquivos de uma certa extensao para uma pasta de origem
// caso um arquivo já exista no destino, não cole e siga para o próximo
// se o diretório não existir, crie ele

Console.WriteLine("qual a pasta de origem dos arquivos?");
string origem = Console.ReadLine();
Console.WriteLine("qual a pasta de destino dos arquivos?");
string destino = Console.ReadLine();
Console.WriteLine("qual a extensão do arquivo que você quer copiar?");
string extensao = Console.ReadLine().ToLower();

if (!Directory.Exists(destino)) 
{ 
    Directory.CreateDirectory(destino);
}

if (!extensao.StartsWith('.'))
{
    extensao = $".{extensao}";
}

int i = 0;

System.IO.DirectoryInfo pastaOrigem = new System.IO.DirectoryInfo(origem);
FileInfo[] arquivos = pastaOrigem.GetFiles($"*{extensao}");

foreach( FileInfo arquivo in arquivos)
{
    if (!File.Exists(destino))
    {
        System.IO.File.Copy($"{origem}\\{arquivo.Name}", $"{destino}\\{ arquivo.Name}");
    }
}

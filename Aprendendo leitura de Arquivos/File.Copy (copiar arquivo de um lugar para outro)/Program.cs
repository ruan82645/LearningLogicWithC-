// System.File.Copy()/Move() são métodos de File que permitem manipular um arquivo de um diretório,
// copiar fazendo uma copia e colando em outro local e Move somente movendo de um dirtório para outro
// eles consistem em passar o caminho do arquivo que queremos copiar ou mover, e o caminho do diretório para colar 
// além desses dois parâmetros obrigatórios, existe um false ou true que podemos marcar
// isso diz que caso haja um arquivo com o mesmo nome no outro local, ele pode ou não sobrescrever esse arquivo
// se não tiver permissão, dará um erro.

// no segundo parâmetro obrigatório, o destino final, escolhemos também se o nome será igual ou diferente, 
// mas o conteudo interno sempre será o mesmo

// ambos copy e move tem exatamente a mesma sintaxe, então se souber um, sabe o outro
// a única diferença de File.Delete é que não precisa de um destino, apenas o caminho do arquivo a ser apagado

// Nesse exemplo, vamos apenas copiar um arquivo para outro diretório
string caminhoOriginal = "C:\\Users\\ruanp\\source\\repos\\Aprendendo leitura de Arquivos" +
    "\\File.Copy (copiar arquivo de um lugar para outro)\\bin\\Debug\\net8.0\\original um\\exemplo1.txt";

string DestinoFinal = "C:\\Users\\ruanp\\source\\repos\\Aprendendo leitura de Arquivos" +
    "\\File.Copy (copiar arquivo de um lugar para outro)\\bin\\Debug\\net8.0\\destino copia\\exemplo1.txt";

System.IO.File.Copy(caminhoOriginal, DestinoFinal);
// o arquivo "exemplo1" agora tem uma cópia com mesmo nome na outra pasta


// agora vamos mover tudo que estava em uma pasta para outra
// para isso, precisamos usar directory para ter todos os caminhos de cada arquivo

string diretorioOriginal = "C:\\Users\\ruanp\\source\\repos\\Aprendendo leitura de Arquivos\\" +
    "File.Copy (copiar arquivo de um lugar para outro)\\bin\\Debug\\net8.0\\original multi";

string diretorioFinal = "C:\\Users\\ruanp\\source\\repos\\Aprendendo leitura de Arquivos" +
    "\\File.Copy (copiar arquivo de um lugar para outro)\\bin\\Debug\\net8.0\\destino copia";

System.IO.DirectoryInfo diretorio = new System.IO.DirectoryInfo(diretorioOriginal);

FileInfo[] arquivos = diretorio.GetFiles();

foreach (FileInfo arquivo in arquivos)
{
    System.IO.File.Copy(arquivo.FullName, $"{diretorioFinal}\\copia_{arquivo.Name}");
}




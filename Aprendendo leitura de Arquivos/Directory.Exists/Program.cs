// Directory.Exists, assim como o File.Exists, verifica a existência de algo.
// A diferença é que enquanto o File.Exists trabalha com arquivos, o Directory.Exists
// trabalha com diretórios, ou seja, ele verifica se uma PASTA existe em um determinado caminho.
// Podemos usar isso em vários cenários, como criar uma pasta apenas se ela não existir, 
// ou mover diretórios para evitar erros caso o diretório de destino já exista.

string destino = "C:\\users\\ruanp\\diretorioDestino";

if (!Directory.Exists(destino))
{
    Directory.CreateDirectory(destino);
}
// Aqui, verificamos se o diretório "diretorioDestino" existe.
// Caso ele não exista, o programa o cria com o Directory.CreateDirectory.
// Ou seja, o Directory.Exists serve como um check antes de qualquer ação com diretórios.

// Lembre-se que, assim como no File.Exists, o Directory.Exists trabalha com UM diretório
// de cada vez, ou seja, ele analisa apenas o diretório que foi passado.
// Se precisar verificar vários diretórios, você precisa de um loop para passar por cada um deles.

// Vou te mostrar outro exemplo em que verificamos a existência de várias pastas.

DirectoryInfo pastaOrigem = new DirectoryInfo("C:\\users\\ruanp\\diretorioOrigem");
DirectoryInfo[] subpastas = pastaOrigem.GetDirectories();

foreach (DirectoryInfo subpasta in subpastas)
{
    if (!Directory.Exists($"C:\\users\\ruanp\\diretorioDestino\\{subpasta.Name}"))
    {
        Directory.Move(subpasta.FullName, $"C:\\users\\ruanp\\diretorioDestino\\{subpasta.Name}");
    }
}
// Aqui estamos lidando com múltiplos diretórios.
// O DirectoryInfo é usado para acessar a pasta "diretorioOrigem", e o GetDirectories
// retorna todas as subpastas dentro de "diretorioOrigem".
// Em seguida, passamos por cada subpasta e verificamos se ela já existe no diretório de destino.
// Se não existir, usamos o Directory.Move para mover a subpasta para lá.
// É importante notar que em cada iteração, estamos verificando uma subpasta por vez.

// Vamos para outro exemplo, agora com o loop For, assim como no exemplo anterior com arquivos.

DirectoryInfo pastaOrigem2 = new DirectoryInfo("C:\\users\\ruanp\\diretorioOrigem");
DirectoryInfo[] subpastas2 = pastaOrigem2.GetDirectories();

for (int i = 0; i < subpastas2.Length; i++)
{
    if (!Directory.Exists($"C:\\users\\ruanp\\diretorioDestino\\{subpastas2[i].Name}"))
    {
        Directory.Move(subpastas2[i].FullName, $"C:\\users\\ruanp\\diretorioDestino\\{subpastas2[i].Name}");
    }
}
// Aqui usamos um loop For ao invés do Foreach.
// O índice (i) muda a cada iteração, representando a subpasta da vez.
// Da mesma forma, verificamos se a subpasta já existe no destino.
// Se não, ela é movida para o destino com o Directory.Move.
// Novamente, note que em cada iteração, temos uma nova subpasta sendo analisada.
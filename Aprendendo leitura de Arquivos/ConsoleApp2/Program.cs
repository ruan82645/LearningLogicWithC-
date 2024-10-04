// GetDirectories funciona assim como o GetFiles().
// ele pega as pastas e armazena dentro de um Array, agora permitindo ter um novo nivel de acesso
// Dessa forma podemos ir de pasta em pasta para pegar arquivos, navegando de forma mais profunda

// Para usar esse método, precisamos utilizar o DirectoryInfo, inicializando uma variavel com o caminho do diretorio pai
// após isso, criar um array do tipo DirectoryInfo[] pois estaremos armazenando informações de cada pasta.
// E pronto, dentro desse array, cada posição equivale a uma pasta,
// e podemos usar o GetFiles para ter acesso aos arquivos dentro dela

DirectoryInfo pastas = new DirectoryInfo("C:\\users\\ruanp\\diretorio");

DirectoryInfo[] pastinhas = pastas.GetDirectories();

FileInfo[] arquivos = pastinhas[0].GetFiles();




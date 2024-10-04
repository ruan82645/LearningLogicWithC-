// A classe path é interessante, ela serve para extrairmos partes do caminho ou pedaços do caminho de uma pasta ou aquivo
// Como assim? No caminho, nós temos os diretórios, nome do arquivo sem extensão e extensão separada,
// Com Path, podemos armazenar em uma string somente a parte que desejamos desse caminho
// podemos ter só o caminho até o diretório, ou só a extensão do arquivo... Por aí vai

// Ela evita de ficarmos tendo que escrever várias vezes o caminho ou etc, ficando automatico
// só precisamos passar uma vez o caminho e ir pedindo para extrair as informações para nós

// Dentro dela, para cada ação dessas de escolher ou caminho, ou extensão, que são os mais usados,
// temos metodos diferentes, um para cada coisa é claro

//----------------------------------------------------------------------------------------------------
// Vou dar alguns exemplos de uso, sempre tendo o mesmo caminho como base

   string caminhoCompleto = "C:\\users\\ruanp\\pastaOrigem\\alabama.txt";
//----------------------------------------------------------------------------------------------------
// Nesse exemplo, vamos pegar somente o caminho do diretório, sem o arquivo

   string diretorio = Path.GetDirectoryName(caminhoCompleto);
   // retorna C:\users\ruanp\pastaOrigem
//----------------------------------------------------------------------------------------------------
// Aqui, vamos pegar somente o nome do arquivo, sem extensão

   string nomeArquivoSemExtensao = Path.GetFileNameWithoutExtension(caminhoCompleto);
   // retorna "alabama"
//----------------------------------------------------------------------------------------------------
// Dessa vez, somente a extensão do arquivo (lembrando que ela sempre vem com ponto)

   string extensao =  Path.GetExtension(caminhoCompleto);
   // retorna ".txt"
//----------------------------------------------------------------------------------------------------

// Esses são os usos mais comuns dele, além do GetFile que usamos em Directory
// Podemos usar bastante nas execuções dos códigos
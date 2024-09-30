// Para podermos ler um arquivo que contenha texto, podemos usar o ReadAllText()
// Como seu nome já diz, "ler todo o texto", ele pega o que está escrito e salva em uma string, onde podemos trabalhar em cima

// Um arquivo de texto não necessáriamente precisa ser um arquivo txt, mas qualquer arquivo que seu principal foco seja texto

// Certo. Como funciona? dentro de ReadAllText, passamos o nome do arquivo que queremos ler com tipo de arquivo(.txt,.cs,.pdf)
// Dentro de ReadAllText existe um caminho já programado (Ex: "c:pasta/dados/arquivo.txt)
// Quando digitamos o nome do arquivo, ele vai procurar somente dentro dessa pasta

//Todos os exemplos estão lendo arquivos reais no computador

    //como saber o local programado? coloque algo errado dentro do parenteses, então no erro ele vai dizer o caminho certo
    //então vá até esse local e salve seu arquivo lá, ai vai funcionar
    ///C:\Users\ruanp\source\repos\Aprendendo leitura de Arquivos\ConsoleApp1\bin\Debug\net8.0
    string textoLido = System.IO.File.ReadAllText("texto.txt");
    Console.WriteLine(textoLido);
    //lê o arquivo e armazena o que foi escrito la dentro, na string

// Ou Podemos mudar o caminho nós mesmos escrevendo ele e o nome do arquivo.
// como assim Ruan? se eu escrever ReadAllText("texto.txt"), ele vai procurar texto.txt dentro de sua pasta pré definida,
// mas e se eu tiver um arquivo para ser lido em outro lugar do computador? Basta mudar o caminho assim:
// ReadAllText("T:\\trabalho/documentos/impostos.txt") é um exemplo... Guiei o leitor até o arquivo em outro local

   string textoLido2 = System.IO.File.ReadAllText("T:\\meuCaminho.txt");
   Console.WriteLine(textoLido2);
   Console.WriteLine();
   ///obs: temos que usar \\ entre o disco e o caminho quando escrevemos diretamente dentro do ReadAllText

// Ou podemos pedir para o usuario mesmo escrever o que e onde quer ler,
// ele digita o caminho, armazenamos esse caminho em uma string e usamos dentro do ReadAllText

   Console.WriteLine("digite o caminho do seu arquivo de texto");
   //digite G:\pasta1\pasta2\caminhoDoUsuario.txt
   string caminho = Console.ReadLine();
   string textoLido3 = System.IO.File.ReadAllText(caminho);
   Console.WriteLine(textoLido2);
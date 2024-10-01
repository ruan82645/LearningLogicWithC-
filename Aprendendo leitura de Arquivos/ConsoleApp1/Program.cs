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
   Console.WriteLine(textoLido3);

// Vamos aos exercicios então!

//1) Nesse exercicio, o caminho do arquivo texto deve ser pedido, e um texto a ser pesquisado dentro desse arquivo
// o arquivo deve ser lido e dependendo do resultado, exibir "texto encontrado" ou "texto não encontrado"
// além disso, devemos usar try catch para evitar que o usuario digite o caminho errado

while (true)
{
    try
    {
        Console.WriteLine("digite o caminho de um texto e o arquivo texto");
        //T:\curso\EU CODO\back\ReadAll.txt
        string caminho2 = Console.ReadLine();
        Console.WriteLine("o que deseja saber se tem nesse arquivo?");
        string pesquisa = Console.ReadLine();

        string textoParaAchar = System.IO.File.ReadAllText(caminho2);

        bool contemPesquisa = textoParaAchar.Contains(pesquisa);

        if (contemPesquisa)
        {
            Console.WriteLine("texto encontrado no arquivo");
        }
        else
        {
            Console.WriteLine("o texto não foi encontrado no arquivo");
        }
        
    }
    catch(Exception erro)
    {
        Console.WriteLine("caminho informado incorreto, motivo: " + erro.Message);
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine($"limpando tela em {i}");
            Thread.Sleep(1000);
        }
        Console.Clear();
    }
}
    

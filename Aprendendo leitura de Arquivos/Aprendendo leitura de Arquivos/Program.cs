// Finalmente chegamos no modulo de leitura de arquivos do sistema
// primeiro, vamos entender um pouco o comando inicial, que são neles que usamos nossos metodos de leitura,

// Para que saibamos o que os diferentes métodos de leitura fazem, é bom entendermos o que vem antes deles,
// esse "System.IO.File". Vamos passar um por um para após isso irmos para os métodos

// perceba que essa linha está lendo um arquivo txt no computador, e trazendo o conteúdo para uma string
// ou seja, se tiver algo escrito em um txt, podemos exibir isso no console por exemplo

// Agora vamos para esses prefixos

// System: ele é a biblioteca dos comandos de C#, é lá que o c# guarda as principais e mais fundamentais funcionalidades do C#

// IO (Input Output): é a parte do system que contem as funções necessárias para trabalhar com funções de entrada e saída de dados
// ou seja, ler e escrever arquivos.



// Dentro de IO, possuímos 3 principais classes com métodos e propriedades diferentes,
// vamos entender quando cada uma deve ser chamada e o que cada uma pode ter dentro de si

//IO.File

// File: é uma classe estática que opera exclusivamente em arquivos individuais de uma única vez.
// Como assim? File executa sua ação no arquivo desejado, sem a possibilidade de mexer em apenas uma parte do arquivo.
// se quisermos ler um arquivo, ele será lido inteiro
// se quisermos mover ou copiar um arquivo para outro local, ele será inteiro afetado
// File permite: ler, mover, copiar, deletar arquivos e outras funções.
// Quando precisar mexer em um arquivo por completo, use File
// Em geral, File lida com o arquivo como um todo,
// mas quando queremos manipular partes específicas, Stream é a melhor opção.

string textoInteiro = System.IO.File.ReadAllText("texto.txt");
//textoInteiro armazena todo o texto do arquivo texto.txt


//IO.DirectoryInfo e IO.Directory

// Essas duas classes se remetem diretamente à todo o conteúdo dentro das pastas(diretórios)
// Eles tem acesso a informações gerais sobre os arquivos existentes dentro da pasta, como o nome de todos por exemplo
// Se quisermos mover a pasta, deletar ela, saber informações sobre cada arquivo dentro de uma pasta, usamos um desses dois.

// DirectoryInfo e Directory são coisas diferentes, uma Info sendo uma classe não estática enquanto Directory é estática.

// Vamos para DirectoryInfo antes de qualquer coisa.
// Como assim? Info necessita de uma variavel iniciada assim como um DateTime, e sempre usando uma variavel DirectoryInfo para mexer,
// ao iniciar o DirectoryInfo, devemos passar o caminho da pasta, a partir disso sua variavel carrega esse caminho,
// agora, com essa variável, temos algumas funções relacionadas aos diretorios, uma muito útil é "GetFiles()",
// GetFiles() armazena as informações sobre todos os arquivos em um array, onde cada posição remete a um arquivo diferente.
// Entenda que ao transformar as informações da pasta em array, agora não é mais sobre a pasta, mas sim sobre arquivo
// quando trabalhamos somente com o arquivo, usamos o tipo "FileInfo", que agora suporta informações de arquivos individuais

string caminho = "C:\\Users\\ruanp\\source\\repos";
System.IO.DirectoryInfo DiretorioInfo = new System.IO.DirectoryInfo(caminho);

FileInfo[] arquivosTipoInfo = DiretorioInfo.GetFiles();

string nomeDoArquivo = arquivosTipoInfo[0].Name;
string CaminhoDoArquivo = arquivosTipoInfo[0].FullName;

// Como cada variavél já possui um valor DirectoryInfo, fica um pouco mais fácil de tratar sobre nomes ou outras coisas
// é um pouco chato iniciar e lembrar que ele troca o tipo de variavel conforme vamos mexer,
// mas quando entendemos o conceito, fica um pouco mais fácil de ir trabalhando com ele.

// Vamos para o .Directory

// Directory é uma classe estática, o que significa que não precisamos setar uma variavel com seu valor,
// podemos apenas chamar o Directory quando queremos usar alguma função dele, sem ficar colocando o tipo Directory
// pode ser tratado diretamente com string mesmo
// ele é mais "fácil" de entender, porém mais trabalhoso para poder pegar informações de arquivos,
// acaba exigindo mais código para fazer algo simples e dependendo de outras classes estáticas.
// digamos que queira fazer o mesmo exemplo de pegar o nome do arquivo, podemos usar o "GetFiles()" ainda

string[] arquivosTipoString = System.IO.Directory.GetFiles("C:\\Users\\ruanp\\source\\repos");

string NomeArquivo = Path.GetFileName(arquivosTipoString[0]);

// parece que usamos menos código, mas sempre que precisar saber alguma informação de um arquivo, terá que escrever algo assim
// cada informação de arquivo, será necessário uma longa linha de código envolvendo diferentes classes com funções difentes,
// além de ter que saber de mais classes e métodos para ter acesso a coisas relativamente simples.
// Uma forma de contornar isso, seria usando um loop, pegando as informações em ordem e já ir usando,
// enquando uma variavel Info já possui diversas informações dentro dela, bastantando apenas chamar um propriedade como "Name"

// Resumindo, ambos os dois tem funções semalhantes, mas formas diferentes de alcançar os mesmos resultados,
// os dois podem ser usados sem problemas, vai do seu gosto, mas levando em consideração que devemos manter o código pequeno
// creio que na maioria das vezes, o Directory info de sobressaia 


// IO.Stream

// O conceito da palavra Stream é meio complexo, mas vamos focar em sua utilidade para saber quando usar.
// Streams são classes não estáticas, que devem ser iniciadas com uma variavel Stream, assim como DateTime.
// Elas permitem que você leia ou escreva dados em partes de forma sequencial usando StreamReader ou StreamWriter
// o que é útil quando o arquivo é muito grande ou quando queremos manipular pequenos pedaços por vez.
// Ao invés de ler um arquivo inteiro, podemos ler linha por linha por exemplo
// quando escrever em um arquivo, podemos escrever linha por linha
// Quando precisar editar algo DENTRO do arquivo, que necessite ser feito ponto a ponto, use o Stream

System.IO.StreamReader leitor = new System.IO.StreamReader("texto.txt");
// com o leitor, podemos ler linha por linha do texto dentro do arquivo.
// esse exeplo é apenas para mostrar como iniciar a variavel,
// está explicado como usar e como funciona esse leitor na aba StreamReader dedicada a ele


// Recapitulação

// Para entender um pouco melhor, Stream é o interior do arquivo, byte por byte; File é o arquivo por inteiro;
// e Directory é a pasta onde são armazenados os arquivos

// Pense no Stream como os orgãos, File como um corpo inteiro e Directory como a casa. 
// Dentro da casa existem 3 pessoas, e dentro dessas 3 pessoas, existem orgãos

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

// Resumo das classes principais para manipulação de arquivos e diretórios

// System.IO.File
// File é uma classe estática usada para trabalhar com arquivos inteiros de uma só vez.
// Ela permite ler, mover, copiar ou deletar arquivos completos.
// Quando você precisa manipular um arquivo como um todo, use a classe File.
// Para mais detalhes, veja o arquivo dedicado a File.

// System.IO.DirectoryInfo e System.IO.Directory
// Essas duas classes são usadas para manipular diretórios (pastas).
// Directory é estática e lida com diretórios sem a necessidade de criar uma instância.
// DirectoryInfo é uma classe não estática, permitindo manipulações mais detalhadas e instanciadas de pastas.
// Para uma explicação mais completa, consulte os arquivos dedicados a DirectoryInfo e Directory.

// System.IO.Stream
// Stream é utilizado para trabalhar com dados dentro de arquivos de forma sequencial, byte por byte.
// Ideal para ler ou escrever pequenos pedaços de dados, como linhas ou partes de um arquivo.
// Para saber mais, consulte o arquivo específico sobre Stream.




// Recapitulação

// Para entender um pouco melhor, Stream é o interior do arquivo, byte por byte; File é o arquivo por inteiro;
// e Directory é a pasta onde são armazenados os arquivos

// Pense no Stream como os orgãos, File como um corpo inteiro e Directory como a casa. 
// Dentro da casa existem 3 pessoas, e dentro dessas 3 pessoas, existem orgãos

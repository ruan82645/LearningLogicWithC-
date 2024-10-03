// Essas duas classes se remetem diretamente à todo o conteúdo dentro das pastas(diretórios)
// Eles tem acesso a informações gerais sobre os arquivos existentes dentro da pasta, como o nome de todos por exemplo
// Se quisermos mover a pasta, deletar ela, saber informações sobre cada arquivo dentro de uma pasta, usamos um desses dois.
// Quando precisamos das informações de um arquivo, vamos até onde ele está guardado e o acessamos de lá.


// Antes de entrarmos nas classes DirectoryInfo e Directory, é importante entender o método GetFiles(),
// que é muito útil para trabalhar com arquivos dentro de uma pasta.

// Como ainda não expliquei sobre os dois, tente entender mais o conceito de como usar o GetFiles()

// O que é o GetFiles()?
// Ele é um método que permite pegar todos os arquivos de uma pasta e armazenar suas informações em um array.
// Isso facilita o acesso e a manipulação dos arquivos, já que para cada item do array, podemos buscar detalhes como:
// nome, caminho completo, tamanho, data de modificação, entre outros.

// Como usar o GetFiles()?
// Você pode chamar o GetFiles() diretamente, passando o caminho da pasta como argumento,
// Exemplo: string[] arquivos = Directory.GetFiles("C:\\caminho\\pasta");
// ou pode usar uma variável que já tenha esse caminho armazenado.
// Exemplo: você pode ter uma variável `DirectoryInfo caminho = new DirectoryInfo("caminho da pasta")`
// e depois chamá-la assim: `var[] arquivos  = caminho.GetFiles()`.

// O GetFiles() também permite usar um filtro opcional, como "*.txt", ou "travasseiro"
// *.txt, *.pdf, etc. Armazenam somente os formatos filtrados
// "travesseiro", "garrafa", etc. Armazena os arquivos que tenham essas palavras.

// Por que é útil?
// O GetFiles() armazena as informações dos arquivos em um array,
// e a partir daí você pode trabalhar com essas informações de forma organizada.
// Por exemplo, você pode pegar apenas o nome dos arquivos, verificar seus tamanhos ou acessar seu caminho completo.
// Esse método é extremamente útil para organizar ou manipular arquivos dentro de um diretório.


// DirectoryInfo e Directory são coisas diferentes, uma Info sendo uma classe não estática enquanto Directory é estática.
// DirectoryInfo necessita de uma variavel iniciada assim como um DateTime, e sempre usando uma variavel DirectoryInfo para mexer,
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
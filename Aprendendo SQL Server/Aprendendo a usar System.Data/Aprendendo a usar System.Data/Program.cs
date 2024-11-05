using System.Data.SqlClient;

// Nesse módulo vamos aprender a usar o Nuget System.Data para estabelecer conexão com o C# e o MySQL via código.
// O System.Data é um pouco obsoleto e temos outra biblioteca que nos permite trabalhar mais facilmente, porém...
// Devemos entender o System.Data antes de ir para ele para que peguemos algumas noções

// Vamos pensar de forma lógica nos passos a serem seguidos para dar os primeiros passos:
// a primeira coisa a se fazer é estabelecer uma conexão com a máquina, dizendo qual banco vamos usar, usuario, senha...
// Então abrimos a conexão 
// depois temos que dizer qual comando vamos executar dentro daquele banco em qual tabela(Igual no sql "select...")
// após isso mandamos executar esse comando 
// Salvamos o que vem do sql
// então exibimos os campos que desejamos enquanto ainda houver dados lá dentro


// ESTABELECENDO CONEXÃO::
// Para isso, nós usamos a classe Sqlconnection e a instanciamos,
// criamos nossa variavel e atribuimos o valor do servidor, banco de dados, acessos dentro dessa classe

    using (SqlConnection conexao = new SqlConnection("Data Source=.; Initial Catalog=Banco_Teste; User ID=ruan;password=ruan82645; MultipleActiveResultSets=True; TrustServerCertificate=True"))
    // por favor, não precisa se preocupar com esse texto gigante, vc apenas precisa copia-lo e passar seus dados até password
{
// ABRINDO CONEXÃO::
// Não basta apenas dizer qual o caminho, precisamos abrir o servidor para que tenhamos acesso,
// então abrimos chaves logo em seguida e é aqui dentro que toda a parte desse caminho será usada.
// Para abrir, chamamos a nossa variavel criada e utilizamos "Open()" para abrir a conexão com o banco de dados
    conexao.Open();


// PASSANDO NOSSO PRIMEIRO COMANDO:
// Utilizando a classe "sqlCommand", a instanciamos, criando uma variavel e atribuindo o valor de qual comando queremos usar.
// Também informamos a qual banco de dados vamos executar esse comando(nossa primeira variavel)
// Vale lembrar que assim apenas colocamos na variável qual comando SERÁ executado quando ORDENADO que execute isso

    SqlCommand selecionarTudo = new SqlCommand("select * from Cliente", conexao);
    // agora "selecionarTudo" quando ordenado a funcionar, vai selecionar todos os campos da tabela Cliente no nosso banco de dados.


// SALVANDO OS DADOS QUE VEM DO BANCO DE DADOS:
// Parece ser uma linha a mais que não tinha necessidade, mas entenda o funcionamento dela:
// quando executamos nosso comando, nós recebemos todos os campos que vieram do banco daquela tabela que selecionamos.
// Quando esses dados vem, precisamos armazenar eles em outro lugar, no caso... Outra variavel que contem as infos dos campos.
// Para isso nós usamos a classe estática "SqlDataReader" criamos uma variavel;
// Esta varável recebe um valor, que é a ordem de execução daquele ultimo comando utilizando ("variavel.ExecuteReader")

    SqlDataReader campos = selecionarTudo.ExecuteReader();
    // por que reader? Porque essa variavel leu todos os campos da tabela "Cliente"
    // agora podemos usar para exibir alguns campos

// EXIBINDO CAMPOS NO CONSOLE
// Parecido com o StreamReader, enquanto houverem linhas a serem lidas, podemos imprimir na tela
// para isso podemos usar um While, passando nossa varável e um "Read()" que faz a função de ir lendo até o fim
// Dentro podemos usar um Console.WriteLine com a nossa variavel e o campo que desejamos exibir

    while (campos.Read())
    {
        Console.WriteLine(campos["nome"]);
    }
    // Então finalmente fechamos as chaves lá do inicio
}

// Lembrando que passei os comandos mais básicos para conexão e para exibição de dados, podemos fazer muito mais
// e faremos muito mais aqui, desde exibir, inserir, deletar, editar. Tentar aplicar isso em um pequeno programa de verdade-
// onde realmente terá funções para o usuário,
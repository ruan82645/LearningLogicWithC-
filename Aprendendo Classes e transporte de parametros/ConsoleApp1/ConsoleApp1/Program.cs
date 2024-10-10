
// Nesse módulo, vamos tentar compreender um pouco mais sobre os paramêtros.
// Mais especificamente sobre divisão de tarefas de um código em multiplas funções,
// Por boa prática e para facilitar a manutenção do códido, é necessário que cada método, possua uma unica função

// porém essa é a parte fácil de entender, a parte mais complicada é pensar em como se dividir,
// no caso a ordem das coisas até finalizar as divisoes e entender o que cada classe retorna e como transportar para outra.
// Vão ter pequenas explicações nesse módulo, a maior parte do aprendizado será em prática, fazendo e lendo os códigos ja feitos.


// Vamos para o básico... O que é NameSpace e como declarar as classes

// Quando criamos uma nova Classe, em outra página, há sempre um Namespace novo, que seria o que usamos com o "using",
// É basicamente o que acompanha a classe como pre fixo


// Tipos de coisas que podemos fazer com classes:
// As classes podem tanto armazenar dados para importar para outra classe,
// quanto processar os dados executando alguma função.
// 
// - Se precisarmos processar poucas informações, podemos passá-las diretamente entre funções.
// - Se estivermos lidando com muitos dados, como os de um arquivo, é mais eficiente salvar
//   essas informações em uma estrutura (como uma lista), para que possam ser usadas por outros métodos ou classes.
//
// Vamos imaginar um cenário onde temos um arquivo de dados, e cada linha possui informações de uma pessoa,
// como nome, telefone, email e CEP. Podemos usar três classes para organizar esse processo:
//
// 1. Uma classe para armazenar as informações de cada pessoa.
// 2. Outra classe para ler os dados do arquivo e armazená-los numa lista.
// 3. Uma terceira classe que utiliza essa lista para realizar alguma operação.
//
// O foco aqui será também explicar como funcionam os **retornos** em cada método.
// O retorno de um método define o **tipo de dado** que ele devolve para quem o chama.
// Isso é importante porque quando chamamos um método, o que recebemos dele pode ser usado para continuar o processamento.
//
// Entendendo o funcionamento dos retornos entre métodos:
// Quando temos uma classe que lida com dados, é comum termos múltiplos métodos com diferentes responsabilidades.
// Vamos imaginar que o primeiro método de uma classe é responsável por ler e armazenar os dados em uma lista.
// Ele **retorna** essa lista, ou seja, devolve a lista para quem chamou o método.
// É isso que significa retornar, dizer que o usuario vai ter acesso a aquela informação para usar em outro local
// Quando usamos um método de IndexOf por exemplo, ele nos RETORNA um int, que é a posição do que pesquisamos
//
// Quando o método é chamado, a lista de dados gerada pode ser salva em uma variável.
// Essa variável pode então ser passada para outros métodos ou classes que farão uso dela.
// 
// Exemplo:
// - O primeiro método "ArmazenarDados" lê e salva os dados de um arquivo e **retorna uma lista de objetos Pessoa**.
// - Quem chama esse método (como o método principal no programa) recebe essa lista e armazena em uma variável.
// - Essa variável com a lista de pessoas pode então ser passada para outro método, que a utilizará para
//   realizar operações como processar os dados ou exibir informações.
// 
// Assim, temos um fluxo de dados:
// 1. Um método retorna os dados (neste caso, uma lista).
// 2. Esses dados são armazenados em uma variável.
// 3. Essa variável é passada para outros métodos ou classes que precisam utilizar esses dados.
//
// Agora, vou mostrar um exemplo em código de como isso funciona:


// vamos pensar em ordem, temos um arquivo com informações e queremos imprimir as informações de cada pessoa no console,
// no caso, todas as informações de uma pessoa numa linha, todas as informações de outra pessoa em outra linha
//
// do que precisamos? LER, ARMAZENAR E PROCESSAR
// 
// não conseguimos armazenar, sem antes ter algum lugar para armazenar? certo? então criamos o armazenamento primeiro,
// após isso seguimos para as outras funções que realmente executam algo.


// Classe 1: Armazenamento de dados
// Esta classe armazena as informações de cada pessoa individualmente.

public class Pessoa
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public string Cep { get; set; }
}

// Classe 2: Armazenamento e leitura de dados
// Esta classe transforma os dados em objetos da classe "Pessoa" e armazena esses objetos em uma lista.
// Como estaremos guardando várias informações dentro de cada tipo de dado da Classe pessoa, temos que criar uma lista,
// essa lista, tem a classe Pessoa dentro, recebendo seu formato, podendo guardar somente os dados que a classe Pessoa pede.
// Significa que cada objeto(linha de dados), será armazenada cada uma em um objeto diferente dentro da lista Pessoa.
// O **retorno** deste método é uma lista de objetos "Pessoa", que será passada para quem chamou o método.

public class ArmazenadorDePessoas
{
    // Este método retorna uma lista de pessoas, que é o que será utilizado por outros métodos
    public List<Pessoa> ArmazenarDados(string caminhoArquivo)
    //        classe Pessoa(agora lista armazena nome, telefone, email e cep em cada objeto)
    //        e o método recebe obrigatóriamente o caminho de um arquivo para ser lido
    {
        // Simulamos a leitura de dados de um arquivo.
        string[] linhas = File.ReadAllLines(caminhoArquivo);
            // digamos que o arquivo possui esses dados em cada linha:

            //João;123456789;joao@email.com;12345-678
            //Maria;987654321;maria@email.com;98765-432
            //Carlos;654987321;carlos@email.com;54321-987
        

        // Criamos uma lista para armazenar os objetos "Pessoa".
        List<Pessoa> listaDePessoas = new List<Pessoa>();

        // Processamos cada linha, criando um objeto "Pessoa" para cada uma,
        // e adicionamos o objeto à lista.
        foreach (var linha in linhas)
        {
            string[] dados = linha.Split(';'); // Divide cada linha nos diferentes campos.

            Pessoa dadosDeUmaPessoa = new Pessoa
            {
                Nome = dados[0],
                Telefone = dados[1],
                Email = dados[2],
                Cep = dados[3]
            };

            listaDePessoas.Add(dadosDeUmaPessoa); // Adiciona o objeto à lista.
        }

        // O método retorna a lista de objetos "Pessoa".
        // O retorno é o que permite que a lista seja passada para quem chamou este método,
        // ou seja, a lista agora estará disponível para ser utilizada em outro lugar.
        return listaDePessoas;
    }
}

// Classe 3: Utilizando os dados armazenados
// Esta classe recebe a lista de pessoas (retornada pela classe anterior) e realiza uma operação.
// Aqui, o método **não retorna nada** (retorno `void`), pois ele só vai exibir os dados.

public class ProcessadorDePessoas
{
    // Este método recebe uma lista de pessoas e utiliza esses dados para realizar uma ação,
    // como exibir as informações. Ele não precisa retornar nada, pois a ação final é processar e exibir os dados.
    public void Processar(List<Pessoa> listaDePessoas)
    {
        foreach (var pessoa in listaDePessoas)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}, Telefone: {pessoa.Telefone}, Email: {pessoa.Email}, CEP: {pessoa.Cep}");
        }
    }
}

// Programa principal para demonstrar o fluxo:
// onde pedimos o caminho e chamamos cada metodo
class Program
{
    static void Main(string[] args)
    {
        // Pedimos o caminho do arquivo e guardamos em uma string, passando ela no método ArmazenarDados
        Console.WriteLine("diga o arquivo que quer ler, armazenar e exibir os dados");
        string caminhoArquivo = Console.ReadLine();

        // Chamamos o método "ArmazenarDados" da classe "ArmazenadorDePessoas".
        // Este método retorna uma lista de pessoas, que será armazenada na variável "listaDePessoas".
        ArmazenadorDePessoas armazenador = new ArmazenadorDePessoas();
        List<Pessoa> listaDePessoas = armazenador.ArmazenarDados(caminhoArquivo); // Recebemos a lista retornada.

        // Agora, passamos essa lista para o método "Processar" da classe "ProcessadorDePessoas".
        // A lista que recebemos do método anterior é agora passada como parâmetro para este método,
        // para que ele possa utilizá-la para processar e exibir os dados.
        ProcessadorDePessoas processador = new ProcessadorDePessoas();
        processador.Processar(listaDePessoas); // Usamos a lista retornada anteriormente.
    }
}
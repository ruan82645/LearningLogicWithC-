
// Este é o mesmo exercicio feito na outra guia, onde devemos transformar um arquivo txt em Excel
// porém aqui, devemos dividir as funções, ao invés de deixar o codigo inteiro em um unico lugar
// farei no mesmo arquivo, sem criar abas de classes diferentes. Classes novas serão criadas com cada função,
// porém no mesmo arquivo para facilitar a explicação que é um pouco complexa

// primeiro, precisamos de uma classe que armazene os dados das pessoas, como nome, telefone e email
// é uma classe simples que não faz nada além de armazenas informação

public class Pessoa
{
    public string nome { get; set; }
    public string email { get; set; }
    public string telefone { get; set; }

}

// A classe Pessoa, agora carrega a informação de uma linha do arquivo texto, mas agora precisamos dela,
// usando em outra classe onde lá, cada linha será salva e guardada

// Pense comigo, não será apenas uma linha, serão multiplas, e a classe pessoa não pode armazenar multiplos valores em uma string.
// não conseguimos colocar 3 nomes diferentes em uma unica string nome por exemplo,
// então para que funcione, precisamos que a classe Pessoa seja como um array ou como uma lista, onde dentro dessa lista tenha:
// varios objetos, cada um com nome, email e telefone. Já que a classe Pessoa tem por padrão 3 informações,
// se uma lista for criada a partir dela, cada objeto dentro terá nome, email e telefone. Uma lista de Pessoas.

// Ou seja, a segunda classe, com a função de ler o arquivo e gravar as informações, deve retornar uma lista com tipo Pessoa.
// é um pouco confuso, mas vamos entender... dentro da classe, deve ser iniciada uma lista com o formato da classe Pessoa, 
// e ao final, quando essa lista estiver cheia, precisamos transportar ela para outro local, certo? 
// para isso, quando declaramos o metodo da segunda classe, precisamos dizer qual o tipo que será retornado lá de dentro

// Quando escrevemos List<> e colocamos a classe Pessoa dentro dos chevrons(<>),
// isso quer dizer que é uma lista que recebe somente as informações que a Classe Pessoa pode receber,
// ou seja, ela só recebe 3 strings e mais nada.

public class LerPessoas 
{
    public List<Pessoa> LerArquivoTexto(string caminhoArquivo)
    // esse método vai retornar uma lista do tipo Pessoa para usarmos em outro local
    {
        var pessoas = new List<Pessoa>();
        // criamos uma variavel que é uma lista, agora essa variavel pode carregar os dados no formato da classe Pessoa
        var linhas = File.ReadAllLines(caminhoArquivo);

        foreach (var linha in linhas)
        {
            var pessoa = new Pessoa();
//          a variavel pessoa, pode armazenar 3 strings, desde que informemos qual info estamos passando para ela
//          essa variavel foi criada para um objeto da lista, a cada iteração vai receber as informações da proxima linha,
//          e quando terminar de receber, vai ser salvo dentro da lista, e na proxima iteração, serão novas infos,
//          repetindo o processo e salvando um novo objeto com informações diferentes

            var valores = linha.Split(';');

            pessoa.nome = valores[0];  // Atribuir o nome
            pessoa.email = valores[1];  // Atribuir o email
            pessoa.telefone = valores[2];  // Atribuir o telefone

            pessoas.Add(pessoa);
//          nessa iteração, ele pegou o objeto atual e salvou na lista, na próxima, ele vai salvar outro objeto
//          no final, é como se fosse: "Pessoas[pessoa1:{nome,email,telefone}; pessoa2:{nome, email, telefone}]"
        }

        return pessoas;
//      como eu disse, o metodo tem "public List<Pessoa>", então ele tem que retornar uma variavel desse tipo,
//      uma variavel com formato List<Pessoa>
    }
}

// Toda essa classe serviu para armazenar cada linha em um objeto diferente dentro de uma lista,
// agora na hora de gerar, podemos usar essa lista para ir de objeto em objeto, preenchendo as células

//Aqui vamos ver dois metodos muito utilizados
//IndexOf(), que na tradução é: "o index de:", creio que seja auto explicativo
//o IndexOf() pesquisa algo que foi passado a ele dentro de uma string
//caso o encontre, ele retorna o int do index daquilo que foi procurado
//vale lembrar que ele encontra a primeira ocorrencia e encerra sua função

//podemos usar muito com o Substring, já que nele precisamos ter a posição inicial de algo

//IndexOf()
{
    string Exemplo1 = "Eu não tenho um carro atualmente";

    int FirstPosicao = Exemplo1.IndexOf("não");
}
//irá retornar 3, que foi onde começou essa palavra ou Char


//uma coisa MUITO IMPORTANTE. Além da string passada para procurar, podemos passar um int
//esse int serve para dizer a partir de qual posição começará a busca
//ao fazer isso, podemos ou ignorar a busca das primeiras ocorrencias
//ou usar em um loop, sempre aumentando esse numero, fazendo buscar o proximo e o proximo
{
    string Exemplo2 = "eu sou homem, eu sou Ruan";
    int SegundaPosicao = Exemplo2.IndexOf("eu", 2);
    //a busca começará a partir do index 2, então não encontrará o primeiro "eu"
    //mas vai me passar a posição da segunda ocorrencia
}



//Agora, vamos ao LastIndexOf(), também sendo bem explicativo, ele retorna a ultima aparição
//Sendo basicamente igual ao IndexOf, tendo essa pequena diferença
{
    string Exemplo3 = "a folha é verde e a grama também é verde";

    int LastPosicao = Exemplo3.LastIndexOf("verde");
    Console.WriteLine(LastPosicao);
}
//irá retornar 35, que foi onde começou a palavra ou Char pela ultima vez

//Um alerta necessário... Caso seja buscado algo que não existe, irá retornar "-1"
//O que podemos tratar usando um "if", que caso dê -1, aquilo não existe


//Agora, aos exercicios

//1) Devemos ter variaveis de nome, email, endereço e data de nascimento
//com isso, devemos gerar um "email" personalizado para a pessoa
//após isso, usando o IndexOf, devemos imprimir somente essas variaveis
//porém, não somente imprimindo a var
//devemos usar o metodo para encontrar cada um dentro do email, para então imprimir
Console.WriteLine("por favor, digite seu nome");
string nome = Console.ReadLine();
Console.WriteLine("seu email por favor");
string email = Console.ReadLine();
Console.WriteLine("me informe seu endereço");
string endereco = Console.ReadLine();
Console.WriteLine("sua data de nascimento");
string dataNacimento = Console.ReadLine();

string mensagem = $@"olá {nome}, como vai? enviei esse email em {email}, pois estamos com uma promoção na sua região, que seria: {endereco}.
//Essa promoção, só está disponivel, pois você nasceu em {dataNacimento}.";

Console.WriteLine(mensagem);
Console.WriteLine();
Console.WriteLine("dados adquiridos:");

Console.WriteLine(mensagem.Substring(mensagem.IndexOf(nome),nome.Length));
Console.WriteLine(mensagem.Substring(mensagem.IndexOf(email), email.Length));
Console.WriteLine(mensagem.Substring(mensagem.IndexOf(endereco), endereco.Length));
Console.WriteLine(mensagem.Substring(mensagem.IndexOf(dataNacimento), dataNacimento.Length));



//2) Aqui iremos treinar usar o int junto com a string para dizer onde procurar
//será feito um loop, onde ele vai encontrar a primeira ocorrencia, aumentar o int
//então buscar a proxima ocorrencia
//devemos exibir os "{exemplo}" de todo o texto, um após o outro
//"Olá {nome}, sei que você mora em {endereço} e vou te ligar em {celular}
//vai imprimir de linha em linha: {nome}\n{endereço}\n{celular}
//string texto = Console.ReadLine();

//int posicao = 0;

//while (true)
//{
//    posicao = texto.IndexOf("{", posicao);

//    if (posicao == -1)
//    {
//        Console.WriteLine("não encontrei mais \"{\"");
//        break;
//    }

//    string variavel = texto.Substring(posicao, texto.IndexOf("}",posicao)-posicao+1);
//    posicao++;

//    Console.WriteLine(variavel);

//}
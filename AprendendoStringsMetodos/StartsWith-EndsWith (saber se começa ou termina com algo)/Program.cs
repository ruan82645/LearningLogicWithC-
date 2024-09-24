//StartsWith e EndsWith é bem auto explicativo
//a string começa com isso?
//a string termina com aquilo?
//usamos para verificar se a string comeã ou termina com algo que determinamos
//ou que o usuario determinou, mas nós usamos mais é claro
//lembrando. Quando o nome do metodo é uma pergunta, é booleano, devolvendo true ou false

string Exemplo1 = "Ruan Pablo Alves da Costa";

bool comecaCom = Exemplo1.StartsWith("Ruan");//True
bool terminaCom = Exemplo1.EndsWith("Ribeiro");//false
//simples demais

//vamos para um exemplo mais real?

string digitadoPeloUsuario = "fulano@yahoo.com";
//só permito passar se for gmail ou hotmail

bool ConfereGmail = digitadoPeloUsuario.EndsWith("gmail.com");
bool ConfereHotmail = digitadoPeloUsuario.EndsWith("hotmail.com");

Console.WriteLine((ConfereGmail || ConfereHotmail) ? "email valido" : "email invalido");
//"email invalido"


//vamos aos exercicios


//1) Aqui, devemos fazer uma verificação do email, assim como no exemplo
//porém devemos verificar se alguem que tem o email correto, possui uma certa tag
//se tiver a tag não autorizada, esse usuario do outro setor, não pode acessar

Console.WriteLine("digite o seu email para acessar");
string emailCorporativo = Console.ReadLine();
//felipearagao@gmail.com
//eletrica.jorgefreitas@agrotecnologia.com.br
//ti.ruancosta@agrotecnologia.com.br

bool ConferirEmail = emailCorporativo.EndsWith("agrotecnologia.com.br");

if (!(ConferirEmail))
{
    Console.WriteLine("sistema disponível apenas para funcionários");
}

bool TiNaoAutorizado = emailCorporativo.StartsWith("ti.");

if (TiNaoAutorizado)
{
    Console.WriteLine("funcionarios da Ti não autorizados. Somente elétrica");
}
else
{
    Console.WriteLine("verificando email...");
    for(int i = 0; i < 3; i++)
    {
        Thread.Sleep(1000);
        Console.Write(".");
    }
    Thread.Sleep(1000);
    Console.WriteLine("\n email autorizado");
}
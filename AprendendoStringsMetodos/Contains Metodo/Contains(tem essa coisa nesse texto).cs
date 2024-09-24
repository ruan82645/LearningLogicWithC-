//Metodo Contains é bem auto explicativo
//Contem? Contem isso aqui dentro desse texto? 
//Essa é a pergunta feita, então ele retorna um bool de true ou false(obviamente)
//podemos usar para verificar uma palavra ou caracter dentro de um texto
//e depois usar isso para fazer algo mais complexo ou não

using System.Linq;

string Exemplo1 = "meu carro ta na oficina";
bool Contain = Exemplo1.Contains("meu carro");
//true, tem "meu carro" na frase

//vamos para o exemplo 2, com ele fazendo alguma coisa

string Exemplo2 = "hoje eu fazer uma festa";
string busca = "festa";

bool Contain2 = Exemplo2.Contains(busca);

Console.WriteLine((Contain2) ? "hoje tem festa" : "não tem festa hoje");

//finalmente para os exercicios

//Nesse bem simples, devemos dizer ao usuario se a letra que ele informou
//existe dentro do texto que ele digitou

//Console.WriteLine("digite um texto");
//string texto = Console.ReadLine();

//Console.WriteLine("qual letra quer saber se existe?");
//string letra = Console.ReadLine();  

//bool temNaoTem = texto.Contains(letra);

//if (temNaoTem)
//{
//    Console.WriteLine($"a letra \"{letra}\" existe sim em \"{texto}\"");
//}
//else
//{
//    Console.WriteLine($"a letra \"{letra}\" não existe em \"{texto}\"");
//};


//Nesse, devemos verificar se arquivo informado pelo usuario é valido
//verificando se a extensão fornecida realmente existe

Console.WriteLine("digite o nome do seu arquivo com a extensão");
string arquivo = Console.ReadLine();

List<string> extensao = new List<string> {".txt", ".pdf" };

bool arquivoCerto = false;

for(int i = 0; i < extensao.Count; i++)
{
    arquivoCerto = arquivo.Contains(extensao[i]);

    if( arquivoCerto){
        break;    
    }
}

if (!(arquivoCerto))
{
    Console.WriteLine("seu arquivo não possui a extensão correta");
}
else
{
    Console.WriteLine("seu arquivo é válido");
}




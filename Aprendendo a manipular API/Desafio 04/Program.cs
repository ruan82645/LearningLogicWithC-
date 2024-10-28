// Nesse desafio um pouco mais simples, devemos consumir uma api que me retorna meu endereço de IP
// com isso, devo escrever a cada 10 segundos em um arquivo, a data e hora completa + o ip

using Desafio_04;

Api api = new Api();
Arquivo arquivo = new Arquivo();
Tempo tempo = new Tempo();

Console.WriteLine("de quantos em quantos segundos ele deve escrever?");
int sleep = tempo.Segundos();

Console.WriteLine("por quanto tempo quer rodar o programa? (em segundos)");
int tempoDuracao = tempo.Segundos();
DateTime duracao = DateTime.Now.AddMilliseconds(tempoDuracao);
int i = 1;

while (DateTime.Now < duracao)
{
    string ip = await api.getIp();
    arquivo.Escrever(ip);
    Thread.Sleep(sleep);
    Console.WriteLine(i);
    i++;
}
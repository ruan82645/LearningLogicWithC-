// StreamReader é uma forma diferente de ler arquivos, onde lemos linha por linha, 
// sem carregar todo o conteudo de uma unica vez, exigindo menos memoria do computador e processamento
// StreamReader diferente do ReadAllText não é um método, mas sim uma classe, entçao sua forma de declarar é diferente
// fazemos da mesma forma que declaramos um DateTime, chamando a classe, passando o nome da variavel e "new" depois disso,
// após escrever pela segunda vez StreamReader na declaração, abrimos parenteses e colocamos o caminho do arquivo lá dentro

StreamReader Exemplo1 = new StreamReader("texto.txt");

// Agora "Exemplo1" carrega a funcionalidade do Stream Reader, mas é um pouco diferente de fazer ele funcionar
// como StreamReader lê linha por linha, precisamos montar um loop que faça ele escrever cada linha uma após a outra,
// com um While no caso. While carrega um parametro, que diz por quanto tempo ele deve funcionar, e fazemos isso aqui.
// devemos informar que ele deve continuar enquanto não chegar o fim do arquivo, 
// "enquanto Exemplo1 não chegar no final da Stream, continue lendo o arquivo"
// Stream tem uma propriedade especifica para dizermos onde é o "final do arquivo", que é o >>>.EndOfStream<<<
// quando colocamos uma variável .EndOfStream, ele retorna um boleano (é ou não é o final do arquivo)
// ou seja, se colocarmos "while(!Exemplo1.EndOfStream)" ele diz "é verdadeiro até acabar o arquivo"

//while (!Exemplo1.EndOfStream)
//{

//}

// E agora por ultimo, precisamos mostrar para o programa que ele deve ler linha por linha e imprimir linha por linha,
// pense comigo, Exemplo1 carrega todo o texto, e temos que dar um jeito para que só uma linha seja impressa por vez.
// O Stream permite que usemos o ReadLine em uma variavel StreamReader, e armazene essa linha em uma string para imprimir depois
// então teriamos que escrever "string linha = Exemplo1.ReadLine()"
// a cada iteração do loop, será lida uma nova linha e essa nova linha será salva e substituirá a anterior na string
// assim podemos imprimir ou usar para outra coisa a string que armazena cada linha

while (!Exemplo1.EndOfStream)
{
    string linha = Exemplo1.ReadLine();
    Console.WriteLine(linha);
}

// Por ultimo, ao terminar de ler o arquivo, precisamos fechar a leitura dele, pois enquanto não estiver fechado
// outros recursos não podem acessar esse arquivo e estará tendo um consumo desnecessário de memoria
// para isso, basta usar um Exemplo1.Close()

Exemplo1.Close();
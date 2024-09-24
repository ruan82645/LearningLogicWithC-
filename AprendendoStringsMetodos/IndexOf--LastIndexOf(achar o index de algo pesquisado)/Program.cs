//Aqui vamos ver dois metodos muito utilizados
//IndexOf(), que na tradução é: "o index de:", creio que seja auto explicativo
//o IndexOf() pesquisa algo que foi passado a ele dentro de uma string
//caso o encontre, ele retorna o int do index daquilo que foi procurado
//vale lembrar que ele encontra a primeira ocorrencia e encerra sua função

//podemos usar muito com o Substring, já que nele precisamos ter a posição inicial de algo

//IndexOf()

string Exemplo1 = "Eu não tenho um carro atualmente";

int FirstPosicao = Exemplo1.IndexOf("não");
//irá retornar 3, que foi onde começou essa palavra ou Char

//Agora, vamos ao LastIndexOf(), também sendo bem explicativo, ele retorna a ultima aparição
//Sendo basicamente igual ao IndexOf, tendo essa pequena diferença

string Exemplo2 = "a folha é verde e a grama também é verde";

int LastPosicao = Exemplo2.LastIndexOf("verde");
Console.WriteLine(LastPosicao);

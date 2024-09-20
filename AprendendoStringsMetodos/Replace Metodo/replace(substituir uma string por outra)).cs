// Metodo Replace é bem tranquilo
// se trata de um metodo para substituir uma string que vc deseja por outra
// escolhemos oq queremos trocar, e pelo que queremos trocar
// então numa frase queremos trocar todos os "a" por "A", usamos Replace
// ou palavras inteiras tbm. trocar vermelho por azul por exemplo
// lembrando que ele troca todas as incidencias, não é só na primeira vez

// exemplo: 

string Exemplo1 = "meu carro é vermelho brilhante";

string Replaced = Exemplo1.Replace("vermelho", "azul");
// "meu carro é azul brilhante"
// também podemos pedir para o usuario digitar aquelas duas propriedades
// agora para o exemplo 2

string Exemplo2 = "Hoje eu fui na praia e almocei na agua";
string busca = "a";
string troca = "A";

string Replaced2 = Exemplo2.Replace(busca, troca);
// "Hoje eu fui nA prAiA e Almocei nA AguA"
// viu? coloquei variaveis tipo string lá nas propriedades obrigatorias

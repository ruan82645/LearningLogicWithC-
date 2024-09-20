// o metodo Join é "simples" de raciocinar
// ele junta o que tiver em um array de string em uma string
// então digamos que vc dividiu um array com o split()
// se quiser juntar ele novamente, com espaços ou outro caracter, use o Join
// como assim com espaços ou outro caracter?
// digamos que vc tenha a frase "amanhã vou comprar pipa"
// ela foi desmontada num array pelo split.
// se imprimir, vai vir tudo junto: "amanhãvoucomprarpipa"
// mas com o Join, especificamos o que queremos entre cada string
// devemos determinar uma string ou char que será colocada entre cada palavra
// E após isso, um array de strings para que seja unido
// ele vai juntar cada palavra com aquilo que voce determinou
// NÃO É POSSIVEL JUNTAR UM TEXTO EM OUTRO TEXTO

string Exemplo1 = "meu pai foi no médico hoje";
string[] palavras = Exemplo1.Split();

string TudoJuntoMisturado = string.Join(",", palavras);
//vai retornar: "meu,pai,foi,no,médico,hoje"

//vamos ao exemplo 2

string Exemplo2 = "ruan,renato,jorge,fernando";
string[] palavras2 = Exemplo2.Split(",");

string TudoJuntoMisturado2 = string.Join("-", palavras2);
Console.WriteLine(TudoJuntoMisturado2);
//vai retornar: "nome: ruan"







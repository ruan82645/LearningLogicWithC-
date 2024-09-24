//Trim basicamente tem a função de remover espaços do inicio e do fim de uma string
//caso o usuario digite ou por algum motivo, seu algoritmo gere espaços indesejados
//podemos usar o Trim() para resolver

using System.Globalization;

string texto = "  Ruan Pablo  ";
Console.WriteLine(texto.Trim());
//tira os espaços do inicio e do fim

//mas e se eu quiser tirar somente do começo ou do final?
//podemos especificar;

string texto2 = "  Larissa Ribeiro  ";
Console.WriteLine(texto2.TrimStart());
//tira os espaços do inicio

string texto3 = "  Leomar Alves  ";
Console.WriteLine(texto3.TrimEnd());
//tira os espaços do final

//E se por acaso(muito dificil) eu quiser tirar algo especifico do inicio ou fim?
//podemos especificar o que desejamos remover

string texto4 = "--Antonia Sulses--";
Console.WriteLine(texto4.Trim('-'));
//remove os caracteres apresentados no inicio e no fim
//também seguindo a mesma lógica do TrimEnd e TrimStart


//Acho que esse não precisa de exercicios...

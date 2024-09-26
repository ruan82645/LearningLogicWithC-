// O metodo PadRight e PadLeft é bem simples de entender também
// ele é usado para preencher um espaço vazio com algo que voce deseja
// PadRight() adiciona para a direita, ao final da string
// PadRight() adiciona para a esquerda, antes de começar a string
//como assim? Digamos que voce tenha "Roberto","Renato" ou "Antonio" escrito
//mas precisa que essa categoria nome sempre tenha 20 caracteres no total
// é isso que o Pad() faz, ele adiciona um caractere até completar o tamanho desejado

// a sua sintaxe é simples, passamos primeiro o tamanho total que a string sempre deve ter
// após isso, passamos qual caracter queremos usar para completar(será " " caso não especifique)
// PadRight/Left(20,"0") -> se a string tiver 4 caracteres, serão colocados 16 "0" para chegar a 20


string Exemplo1 = "ruan";
string PaddedRight = Exemplo1.PadRight(10, '0');
//PaddedRight vai valer "ruan0000000"

string Exemplo2 = "Larissa";
string PaddedLeft = Exemplo2.PadLeft(10, '0');
//paddedLeft vai valer "0000Larissa"

string Exemplo3 = "000Leomar000";
string PaddedGeral = Exemplo3.PadLeft(10, '0').PadRight(20, '0');


//vamos ao exercicio de fixação, mas antes vou explicar uma coisa
//em bancos(bancos mesmo), na hora de passar certas informações, o conteudo é passado em um txt
//do caracter 0 ao 25, deve estar o nome, do 26 ao 50, o email, e assim por diante
//quando sobra espaço, ele é preenchido com um caracter diferente

//Agora sim, ao exercicios, aqui devemos fazer um código de 100 caracteres
//onde de 1-25, deve estar a data de nascimento, ela deve ser alinhada a direita com "X"
//26 - 50, o nome alinhado à esquerda, preenchido por "#"
//e por ultimo, do 51-100, o email à direta, preenchido por "$"

Console.WriteLine("digite sua data de nascimento, nome e email. dê um enter a cada um digitado");
string dataNascimento = Console.ReadLine().PadLeft(25,'X');
string nome =  Console.ReadLine().PadRight(25,'#');
string email = Console.ReadLine().PadLeft(50,'$');

Console.WriteLine($"{dataNascimento}{nome}{email}");
// Nesse arquivo, vamos ver metodos já existentes para tratar strings
// Como assim? mexer com elas, deixa maiuscula, colocar uma coisa no final... etc
// Formatar strings com métodos já existentes do C#

// Vamos do mais básico
// Escape sequence e Interpolation

// Usamos "\" antes de alguma coisa que já existe em C#, para dizer que na vdd é um texto
// Por exemplo: aspas... Aspas não podem ser usadas dentro da string sem o auxilio do "\"
// Algumas combinações tem funções diferentes, tipo o "\n" que pula para a linha abaixo
Console.WriteLine("Usando Escape sequence");
Console.WriteLine("hoje, estudei \"pouco\", só 10 horas kkkk");
Console.WriteLine();

// Interpolação é o básico, nem vou explicar
Console.WriteLine("Usando Interpolação");
string nome = "Ruan";
Console.WriteLine($"Meu nome é {nome}");
Console.WriteLine();

// arroba, sim... "@". Podemos usar para quebrar as linhas na string de forma mais fácil
// basta usar como o "$", antes das aspas, eles podem ser combinados tbm

Console.WriteLine("Usando \"@\"");
Console.WriteLine(@"hoje
eu
acordei
");
Console.WriteLine();

// Agora algo que não é muito utilizado, e 2% mais complexo, que é o "String.Format()"
// ele serve para meio que fazer um array com as variaveis que vão dentro da string
// e usar elas de acordo com sua posição index
// lembrando que vc pode usar os "{x}" quantas vezes quiser, onde quiser

Console.WriteLine("Usando Interpolação");
string trabalho = "desenvolvedor";
string idade = "20";
string nome2 = "Ruan Pablo";
//                                             {0}                {1}          {2}   /  {0}      {1}    {2}
Console.WriteLine(string.Format("Olá, eu sou o {0}, trabalho como {1}, e tenho {2} ", trabalho, idade, nome2));
Console.WriteLine();

//os demais ficarão um em cada arquivo...
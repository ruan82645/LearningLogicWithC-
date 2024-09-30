// Da mesma forma que usamos de Parse para transformar uma string em um numero
// Também usamos Parse para transformar uma string em um objeto DateTime
// Afinal, mesmo que tenhamos digitado 26/09/2024, isso não é uma data para o sistema
// Somente após a conversão, podemos usar as propriedades e métodos do Real DateTime
// E da mesma forma que o int, parseamos o conteudo da string para uma variavel DateTime

//    Console.WriteLine("digite uma data no formado dd/MM/yyyy");
//    string DataString = Console.ReadLine();
//    DateTime DataConvertida = DateTime.Parse(DataString);

//    Console.WriteLine("agora essa data foi convertida e pode ser usada para calculos e mais coisas");

//    // Ou podemos converter da forma clássica que é dar o parse na hora do ReadLine

//    Console.WriteLine("digite uma data no formado dd/MM/yyyy");
//    DateTime DataConvertidaNoAto = DateTime.Parse(Console.ReadLine());

//    Console.WriteLine("agora essa data foi convertida e pode ser usada para calculos e mais coisas");

// Agora que sabemos ter acesso a qualquer informãção de um DateTime, podemos calcular coisas, como sua idade por exemplo!
// basta pegar o ano do seu nascimento e subtrair pelo ano atual

Console.WriteLine("digite sua data de nascimento para calcular sua idade");
DateTime Nascimento = DateTime.Parse(Console.ReadLine());

int idade = DateTime.Now.Year - Nascimento.Year;

Console.WriteLine("você tem " + idade + " anos de idade");

// E se eu quiser saber exatamente quanto tempo de vida você tem? Nesse caso, que sejam passadas todas as informações,
// sem pegar uma unica coisa, vamos usar tudo aqui, desde anos, meses, dias, horas e segundos
// TimeSpan é usado para armazenar a diferença entre duas datas(ela não tem propriedade de ano, mes e semana. Apenas dia para baixo)

Console.WriteLine("digite sua data de nascimento para calcular seu tempo de vida");
DateTime Nascimento2 = DateTime.Parse(Console.ReadLine());
TimeSpan diferenca = DateTime.Now - Nascimento2;

int idadeatual = DateTime.Now.Year - Nascimento2.Year;
int mesesatuais = (idadeatual * 12) + DateTime.Now.Month - Nascimento2.Month;
double semanasatuais = diferenca.TotalDays / 7;

Console.WriteLine($"você tem {idadeatual} anos, {mesesatuais} meses, {semanasatuais} semanas, {diferenca.Days} dias, {diferenca.TotalHours} horas e {diferenca.TotalSeconds} segundos");

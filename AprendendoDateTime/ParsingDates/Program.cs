// Da mesma forma que usamos de Parse para transformar uma string em um numero
// Também usamos Parse para transformar uma string em um objeto DateTime
// Afinal, mesmo que tenhamos digitado 26/09/2024, isso não é uma data para o sistema
// somente após a conversão, podemos usar as propriedades e métodos do Real DateTime
// E da mesma forma que o int, parseamos o conteudo da string para uma variavel DateTime

    Console.WriteLine("digite uma data no formado dd/MM/yyyy");
    string DataString = Console.ReadLine();
    DateTime DataConvertida = DateTime.Parse(DataString);

    Console.WriteLine("agora essa data foi convertida e pode ser usada para calculos e mais coisas");

    // Ou podemos converter da forma clássica que é dar o parse na hora do ReadLine

    Console.WriteLine("digite uma data no formado dd/MM/yyyy");
    DateTime DataConvertidaNoAto = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("agora essa data foi convertida e pode ser usada para calculos e mais coisas");

// Agora com a data convertida, temos acesso as suas propriedades
// Que propriedades Ruan? Você não explicou isso.
// Propriedades são as informações especificas que podemos tirar da variavel DateTime,
// sem ter que ficar usando ToString(), afinal, ToString serve para mostrar isso em tela,
// porém se eu quiser usar somente o dia de hoje, ou um dia especifico de uma data completa que foi informada pelo usuario?
// Dependendo se a variavel tiver valor de .Now ou .Today, digitamos "." após isso e temos acessos a dados especificos
// vou mostrar no exemplo:

// Aqui, eu não comparo ano, não comparo mês, apenas peguei o dia "24" para ser comparado,
// mas posso usar, minuto, segundo, dia, ano, hora, ou o que eu quiser usar de uma variavel com valor DateTime

DateTime AniversarioLarissa = new DateTime(2004, 03, 30);

if (AniversarioLarissa.Day >= DateTime.Today.Day)
{   //perceba que Aniversario já tinha informação de data, então não precisava de um Today ou qualquer coisa,
    //porém ao criar um DateTime novo, precisei dizer quais valores ele tem(.Today), para pegar um em especifico(.Day)
    Console.WriteLine("hoje é dia 24 ou maior");
}
else
{
    Console.WriteLine("ainda está antes do dia 24 do mês atual");
};


// Agora que sabemos ter acesso a qualquer informãção de um DateTime, podemos calcular coisas, como sua idade por exemplo!
// basta pegar o ano do seu nascimento e subtrair pelo ano atual

    Console.WriteLine("digite sua data de nascimento para calcular sua idade");
    DateTime Nascimento = DateTime.Parse(Console.ReadLine());

    int idade = DateTime.Now.Year - Nascimento.Year;

    Console.WriteLine("você tem" + idade + " anos de idade");

// E se eu quiser saber exatamente quanto tempo de vida você tem? Nesse caso, que sejam passadas todas as informações,
// sem pegar uma unica coisa, vamos usar tudo aqui, desde anos, meses, dias, horas e segundos

    Console.WriteLine("digite sua data de nascimento para calcular seu tempo de vida");
    DateTime Nascimento2 = DateTime.Parse(Console.ReadLine());

    int idadeatual = DateTime.Now.Year - Nascimento2.Year;
int mesesatuais = DateTime.Now.Month - Nascimento2.Month;

Console.WriteLine($"você tem {idadeatual} anos, {mesesatuais} meses, X semanas, X dias, X horas e X segundos");
    

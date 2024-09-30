// Substract é usado para saber a diferença entre um tempo e outro
// Nos permitindo subtrair dois tempos diferentes e obter tudo que passou dentro disso
// isso pode nos informar a quantidade total de dias,horas,minutos,segundos,etc que ocorreram nesse tempo
// para usa-lo, precisamos de duas variaveis com valor Date Time, uma para fora do Substract e outra para dentro
// essa diferença deve ser passada para uma variavel do tipo "timeSpan", que pode armazenar esse tipo de informação
// Span = "periodo" / timeSpan = "periodo de tempo"

DateTime Exemplo = new DateTime(2020, 12, 02);
DateTime ExemploAgora  = DateTime.Now;

TimeSpan diferenca = ExemploAgora.Subtract(Exemplo);

// Agora com uma variavel que carrega uma diferença entre dois tempos diferentes, podemos acessar informações especificas
// como dias totais, horas totais, minutos totais e por aí vai. Tudo que aconteceu dentro desse periodo de tempo
// para acessa-los, basta usar um "." após a variavel e digitar "total" e teremos os resultados que queremos
// vale lembrar que os resultados vem em forma de double

double diasTotais = diferenca.TotalDays;
Console.WriteLine($"se passaram {diasTotais:N0} dias");

//Vamos para os exercicios

//1) E se eu quiser saber exatamente quanto tempo de vida você tem? Nesse caso, que sejam passadas todas as informações,
// sem pegar uma unica coisa, vamos usar tudo aqui, desde anos, meses, dias, horas e segundos
// TimeSpan é usado para armazenar a diferença entre duas datas(ela não tem propriedade de ano, mes e semana. Apenas dia para baixo)

Console.WriteLine("digite sua data de nascimento para calcular seu tempo de vida");
DateTime Nascimento2 = DateTime.Parse(Console.ReadLine());
TimeSpan diferenca2 = DateTime.Now.Subtract(Nascimento2);

int idadeatual = DateTime.Now.Year - Nascimento2.Year;
int mesesatuais = (idadeatual * 12) + DateTime.Now.Month - Nascimento2.Month;
double semanasatuais = diferenca2.TotalDays / 7;

Console.WriteLine($"você tem {idadeatual} anos, {mesesatuais} meses, {semanasatuais:N0} semanas, {diferenca2.Days:N0} dias, {diferenca2.TotalHours:N0} horas e {diferenca2.TotalSeconds:N0} segundos");

//2) Aqui devemos ter um programa que calcula a diferença entre o dia que um funcionario saiu e retornou de férias
// deve perguntar o salario dele e para cada dia de férias, descontar R$: 15,00 reais de seu salario
// caso o valor seja negativo, deve virar 0

Console.WriteLine("quando saiu de férias?");
DateTime saiu = DateTime.Parse(Console.ReadLine());
Console.WriteLine("quando retornou das férias");
DateTime voltou = DateTime.Parse(Console.ReadLine());
Console.WriteLine("qual seu salário");
double salario = double.Parse(Console.ReadLine());

double cobranca = 0;

TimeSpan ferias = voltou.Subtract(saiu);

for(int i = 0; i < ferias.TotalDays; i++)
{
    cobranca += 15;
}

double salarioFinal = salario - cobranca;

if(salarioFinal < 0)
{
    salarioFinal = 0;
}

Console.WriteLine($"foram descontados {cobranca:C2} de seu salário em suas férias de {ferias.TotalDays} dias");
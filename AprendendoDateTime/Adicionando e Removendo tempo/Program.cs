// também podemos adicionar e remover tempo de uma variavel DateTime através do .Add
// ao chamar a variavel, podemos usar o .Add e escolher qual tipo de tempo desejamos adicionar
// seja de milisegundos até anos
// lembrando que o valor alterado deve ser salvo em uma nova variavel, a original, não será alterada
// para adicionar, colocamos o valor positivo, enquanto para subtrair, colocamos o valor negativo

    DateTime Exemplo = new DateTime(2024, 09, 30);
    DateTime SemanaQueVem = Exemplo.AddDays(7);
    //SemanaQueVem = "2024, 10, 07"

    DateTime Exemplo2 = new DateTime(2024, 09, 30);
    DateTime SemanaPassada = Exemplo.AddDays(-7);
//SemanaQueVem = "2024, 09, 24"

// É algo bem simples, então vamos para os exercicios

//1) Hipoteticamente, no Google, todos os funcionários possuem um dia de folga no ano.
// Esse dia depende do dia da semana em que ele foi contratado.
// segunda: após 77 dias da contratação
// quarta: após 2 meses da contratação
// Para todos os demais dias, a folga é em 01 de junho.
// o programa deve receber o dia do usuario e informar quando será a proxima folga

Console.WriteLine("digite o dia de sua contratação");
DateTime contratacao = DateTime.Parse(Console.ReadLine());
// 30/09/2024

DateTime folga;

if(contratacao.DayOfWeek == DayOfWeek.Monday)
{
   folga = contratacao.AddDays(77);
}
else if (contratacao.DayOfWeek == DayOfWeek.Wednesday)
{
    folga = contratacao.AddMonths(2);
}
else
{
    DateTime referencia = new DateTime(2000,06,01);
    if(contratacao.Month >= referencia.Month)
    {
        folga = new DateTime(DateTime.Now.Year, 06, 01).AddYears(1);
    }
    else
    {
        folga = new DateTime(DateTime.Now.Year, 06, 01);
    }
}

Console.WriteLine($"você terá folga em {folga.ToString("dd/MM/yyyy")}");

/* O programa deve pedir um número. Se o usuário digitar um número como texto, gerará erro.
 O programa deverá capturar isso na exception e orientar ao usuário*/



//using System.Diagnostics;

//while (true)
//{
//    try
//    {
//        Console.WriteLine("por favor, digite um número");
//        int idade = int.Parse(Console.ReadLine());
//    }
//    catch(Exception error)
//    {
//        Console.WriteLine(error.Message);
//    }
//}

/*Crie um programa que peça ao usuário para digitar um número decimal e tente converter esse valor.
 * Se a conversão falhar, o programa deve usar try-catch para capturar a exceção,
 * exibir uma mensagem de erro e continuar pedindo o valor.*/


//decimal Decimais = 0m;


//    while (true)
//    {
//        Console.WriteLine("digite um valor decimal");
//        var inputDecimal = Console.ReadLine();

//    try
//    {
//        Console.WriteLine("opa, o número digitado foi " + decimal.Parse(inputDecimal));
//    }
//    catch(Exception erro)
//    {
//        if(!decimal.TryParse(inputDecimal, out Decimais)){
//            Console.WriteLine("erro encontrado : " + erro.Message);
//        }
//    }

//}

/*Neste exercício, você vai pedir ao usuário para digitar uma data (formato dd/MM/yyyy). 
 *O programa deve usar DateTime.TryParse para validar a entrada do usuário. 
 *Caso o usuário insira um formato de data incorreto, ele deve ser informado do erro. 
 *No entanto, inclua um cenário onde, se houver uma exceção inesperada, 
 *ela seja tratada com try-catch e uma mensagem de erro apropriada seja exibida.*/


//DateTime dataHoje = new DateTime();

//while (true)
//{
//    Console.WriteLine("por favor, digite a data de hoje no formato dd/mm/yyyy");

//    var inputDataHoje = Console.ReadLine();

//    try
//    {
//        if (!DateTime.TryParse(inputDataHoje, out dataHoje))
//        {
//            Console.WriteLine("data digitada de forma incorreta");
//        }
//        else
//        {
//            Console.WriteLine("voce digitou a data de hoje: " + dataHoje.ToString());
//        }
//    }
//    catch(Exception error)
//    {
//        Console.WriteLine("erro inesperado aconteceu: " + error.Message);
//    }


//}


/*Neste exercício, você pedirá ao usuário dois números e realizará uma divisão entre eles. 
 *Use TryParse para garantir que os números são válidos e try-catch para capturar possíveis exceções, 
 *como a divisão por zero. 
 *A ideia é diferenciar entre quando TryParse pode ser usado para evitar conversões inválidas 
 *e quando try-catch é útil para capturar exceções lógicas (como uma operação matemática inválida).*/

using Exceptions;

divisao conta = new divisao();

int dividendoValor;
int divisorValor;

try
{
    while (true)
    {
        Console.WriteLine("informe um número para ser dividido");
        var inputDividendo = Console.ReadLine();

        if (int.TryParse(inputDividendo, out dividendoValor))
        {
            conta.dividendo = dividendoValor;
            break;
        }
        else
        {
            Console.WriteLine("valor digitado incorretamente");
        }
    }

    while (true)
    {
        Console.WriteLine("informe um número a dividir o ultimo valor");
        var inputDivisor = Console.ReadLine();

        if (int.TryParse(inputDivisor, out divisorValor))
        {
            conta.divisor = divisorValor;
            break;
        }
        else
        {
            Console.WriteLine("valor digitado incorretamente");
        }
    }

    Console.WriteLine("a divisão feita agora tem o resultado de: " + conta.divididos().ToString("F1"));
}
catch(Exception error)
{
    Console.WriteLine("erro inesperado aconteceu: " +  error.Message);
}






// Agora vamos falar sobre a formatação do DateTime.

// Para modificar como as informações são apresentadas, usamos métodos específicos
// e uma forma de escrever dentro desses métodos.

// Um dos métodos principais é o ToString(), que nos permite formatar as informações como quisermos.
// Se deixar vazio, ele retorna no formato padrão.

// Também existem métodos automáticos (não personalizaveis):
// - ToShortDateString() = exibe apenas a data no formato padrão (dd/MM/yyyy).
// - ToLongDateString() = exibe a data por extenso (ex: "quinta-feira, 26 de setembro de 2024").
// - ToShortTimeString() = exibe a hora com minutos (ex: 16:32).
// - ToLongTimeString() = exibe a hora com minutos e segundos (ex: 16:32:55).

// Para aprender mais sobre como formatar datas e horas, você pode consultar o formulário da Microsoft, 
// que explica todas as tags de formatação disponíveis (que vão de "HH"(hora) até "ffffff"(milionesimo de segundo):
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings

// Exemplos:

DateTime formatado = DateTime.Now;
Console.WriteLine("Formatando com ToString()\n");

Console.WriteLine(formatado.ToString("dddd, dd/MMMM/yyyy") + ": ToString(\"dddd, dd/MMMM/yyyy\")");
// quinta-feira, 26 de setembro de 2024 (Exemplo)
Console.WriteLine(formatado.ToString("ddMMyyyy HHmmss") + ": ToString(\"ddMMyyyy HHmmss\")");
// 26092024 163255 (Exemplo)
Console.WriteLine(formatado.ToString("MM/yyyy") + ": ToString(\"MM/yyyy\")");
// 09/2024 (Exemplo)
Console.WriteLine(formatado.ToString("dd/MM HH:mm") + ": ToString(\"dd/MM HH:mm\")");
// 26/09 16:32 (Exemplo)
Console.WriteLine(formatado.ToString("dd HH:mm:ss") + ": ToString(\"dd HH:mm:ss\")");
// 26 16:32:55 (Exemplo)
Console.WriteLine(formatado.ToString($"yyyy HH") + ": ToString($\"yyyy HH\")");
// 2024 16 (Exemplo)
Console.WriteLine();



Console.WriteLine("Formatando com métodos automáticos");
Console.WriteLine(formatado.ToShortDateString());// 26/09/2024
Console.WriteLine(formatado.ToLongDateString());// quinta-feira, 26 de setembro de 2024  
Console.WriteLine(formatado.ToShortTimeString());
Console.WriteLine(formatado.ToLongTimeString());
Console.WriteLine();

// Também podemos usar a interpolação de strings para chamar a variável já formatada,
// ou formatar diretamente no próprio texto, sem precisar do ToString().

Console.WriteLine("Formatando na interpolação por $");
Console.WriteLine($"Agora são exatamente: {formatado:HH:mm:ss} do dia {formatado:dd}");
Console.WriteLine();

// Ou podemos chamar uma variável já formatada:

Console.WriteLine("Chamando variavel já formatada");
DateTime agora = DateTime.Now;
agora.ToString("HH:mm:ss");
Console.WriteLine($"Agora são exatamente: {agora}");
Console.WriteLine();


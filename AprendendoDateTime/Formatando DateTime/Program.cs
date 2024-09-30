// Agora vamos falar sobre a formatação do DateTime.

// para isso, temos que ter um DateTime.Now, que garante mais informações a serem passadas, ou...
// um DateTime que nós mesmos colocamos as informações lá dentro(já irei explicar).
// Para modificar como as informações são apresentadas, usamos métodos específicos
// e uma forma de escrever dentro desses métodos.

// Para utiliza-lo, não podemos usar direto quando criamos o DateTime, o valor deve ser passado para a variavel depois,
// ou então formatada direto na impressão do console

// Para formatar diretamente no console, chamamos a variavel que criamos com DateTime.Now,
// e então aplicamos a formatação usando o Console.WriteLine("variavelAqui".ToString("bla,bla,bla")) 

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

Console.WriteLine("ToString(\"dddd, dd/MMMM/yyyy\"): " + formatado.ToString("dddd, dd/MMMM/yyyy"));
// quinta-feira, 26 de setembro de 2024 (Exemplo)
Console.WriteLine("ToString(\"ddMMyyyy HHmmss\"): " + formatado.ToString("ddMMyyyy HHmmss"));
// 26092024 163255 (Exemplo)
Console.WriteLine("ToString(\"MM/yyyy\"): " + formatado.ToString("MM/yyyy"));
// 09/2024 (Exemplo)
Console.WriteLine("ToString(\"dd/MM HH:mm\"): " + formatado.ToString("dd/MM HH:mm"));
// 26/09 16:32 (Exemplo)
Console.WriteLine("ToString(\"dd HH:mm:ss\"): " + formatado.ToString("dd HH:mm:ss"));
// 26 16:32:55 (Exemplo)
Console.WriteLine("ToString($\"yyyy HH\"): " + formatado.ToString($"yyyy HH"));
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

// Ok, entendi como usar o que já está no sistema, e se eu quiser criar um DateTime com os dados que eu quero?
// verificar se a data de hoje é o aniversário de alguém por exemplo. Eu teria que ter o aniversario da pessoa + o dia de hoje
// então como posso criar uma variavel que carregue as informações que eu criei?
// ao criar a variavel, devemos iniciarlizar o metodo com um "new DateTime()"
// e dentro do parenteses, colocar as informações de Ano até onde você quiser parar
// lembrete, as informações são agrupadas de 3 em 3(ano, mes e dia),(hora,minuto,segundo)
// se eu quiser colocar a hora, devo colocar minuto e segundos também (coloque 00 caso não saiba ou não deseje que tenha valor)
// Obeserve o exemplo: 

//                                        (ano   mês  dia) (hora min  seg)
DateTime AniversárioLarissa = new DateTime(2003, 03,   24,   16,  32,  00);


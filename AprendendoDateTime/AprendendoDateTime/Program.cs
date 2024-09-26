// o DateTime é o que usamos para trabalhar com data e hora em todo o programa
// ele acessa as informações do calendário e relógio do computador e não do horario real da sua região
// o que significa que se a hora do computador estiver errada, a hora do DateTime também vai estar

// uma informação importante é que o DateTime não fica se atualizando como um relógio
// ele salva o valor do momento exato em que o programa foi iniciado
// então se rodar um programa na hora atual de (16:32 por exemplo)
// e mais tarde chamar esse mesmo DateTime, os dados vão permanecer de 16:32, pois não se atualiza sozinho
// para ficar se atualizando, deveriamos fazer um loop, onde o valor ficaria sendo atualizado constantemente

// ao usar as informações do computador, o DateTime carrega algumas propriedades estáticas obrigatórias.
// Como assim? Se eu quiser usar as informações de data ou hora do computador, tenho que passar o que eu quero receber.
// Algumas dessas propriedades são o: DateTime.Now e o DateTime.Today

// O DateTime.Now trabalha trazendo TODAS as informações do momento exato em que foi criado ou atualizado
// podendo trazer ano, mês, dia, hora, minuto, segundo, decimos de segundo e assim vai
// o padrão é mostrar ano,mês, dia e hora, minuto e segundo
// porém se quiser, podemos mostrar mais informações ou formas diferentes de exibir os resultados
// desde o dia aparecer como: 26/09/2024, até aparecer como: quinta-feira, 26, de novembro de 2024 

// O DateTime.Today passa somente as informações sobre o dia, mês e ano. Sem hora, minutos ou etc

DateTime normal = DateTime.Now;
// dd/MM/yyyy  HH:mm:ss (dados de quando você rodar o programa)
Console.WriteLine(normal);

// Ok, mas como podemos alterar as informações passadas para o usuário em tela? 
// para isso, temos que ter um DateTime.Now, que garante mais informações a serem passadas, ou...
// um DateTime que nós mesmos colocamos as informações lá dentro(já irei explicar).
// Com isso, temos que usar tanto um método, quanto uma forma de escrever dentro desse mesmo método
// Para utiliza-lo, não podemos usar direto quando criamos o DateTime, temos que usar só na hora de imprimir na tela.
// Chamando a variavel que armazena aquele valor, e então aplicando a formatação
// usando o Console.WriteLine("variavelAqui".ToString("bla,bla,bla")) 

// métodos utilizados:
// ToString() = nos permite formatar como quisermos as informações passadas, caso em branco, será passado as padrões.
// ToShortDateString() = (está escrito apenas "Date") é um método automatico que passa a data no formato padrão.
// ToLongDateString() = (está escrito apenas "Date") é um método também automático que passa a data por extenso em tela.

// Agora, a forma de escrever dentro do metodo:
// Esse padrão foi criado pela Microsoft, então deve ser seguido certinho, pois é CaseSensitive
// os mais comuns para data são "dd/MM/yyyy" e para hora: "HH:mm:ss"
// podemos brincar com isso, mostrando somente minutos, ou somente o dia por exemplo
// "variavelAqui".ToString("yyyy HH") = aqui seria mostrado somente ano e hora
// Também existem outras formas de exibir o mesmo tipo de informação ou outro tipo
// Como assim? Para escrever o dia de forma abreviada, é "ddd" e escrever o dia por extenso é "dddd" por exemplo
// Mas se eu quiser escrever milésimos de segundo ou outro dado, já seria outra junção de letras, "fff" por exemplo
// Existem varios tipos de formas de exibir varios tipos de reultados, e estão todos catalogados aqui:
// https://learn.microsoft.com/en-us/dotnet/standart/base-types/custom-date-and-time-format-strings


// Date Time é um método do sistema, ou seja, quando criamos uma variavel que armazena data, devemos inicializa-la
// também pense em DateTime como um tipo, então uma variavel é do tipo DateTime
// então como assim inicia-la ao criar uma variavel?
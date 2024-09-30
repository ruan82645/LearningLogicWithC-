// o DateTime é o que usamos para trabalhar com data e hora em todo o programa
// ele acessa as informações do calendário e relógio do computador e não do horario real da sua região
// o que significa que se a hora do computador estiver errada, a hora do DateTime também vai estar
// Date Time é um método do sistema, ou seja, quando criamos uma variavel que armazena data, devemos inicializa-la com "new"
// também pense em DateTime como um tipo, então uma variavel é do tipo DateTime
// então como assim inicia-la ao criar uma variavel?

   DateTime Exemplo = new DateTime();
   //--------------------------------- 
   DateTime Long = DateTime.Now;
   Console.WriteLine(Long.ToLongDateString());

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
// o padrão (caso não informe se quer mais coisas) é mostrar ano,mês, dia e hora, minuto e segundo
// porém se quiser, é possivel mostrar mais informações ou formas diferentes de exibir os resultados,
// desde o dia aparecer como: 26/09/2024, até aparecer como: quinta-feira, 26, de novembro de 2024 

// O DateTime.Today passa somente as informações sobre o dia, mês e ano. Sem hora, minutos ou etc

   DateTime DataHoraAtual = DateTime.Now;
   // dd/MM/yyyy  HH:mm:ss (dados de quando você rodar o programa)
   Console.WriteLine("usando o DateTime.Now e trazendo data e hora atuais:");
   Console.WriteLine(DataHoraAtual);

   DateTime DataAtual = DateTime.Today;
   // dd/MM/yyyy (dados do dia que o programa for rodado)
   Console.WriteLine("usando o DateTime.Today e trazendo a data atual:");
   Console.WriteLine(DataAtual);
   
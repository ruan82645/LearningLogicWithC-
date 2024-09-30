// Além do .Now e .Today, o DateTime possui outros parâmetros, que são mais especificos
// Que parâmetros Ruan? Você não explicou isso.
// parâmetros são as informações especificas que podemos tirar da variavel DateTime,
// sem ter que ficar usando ToString(), afinal, ToString serve para mostrar isso em tela,
// porém se eu quiser usar somente o dia de hoje, ou um dia especifico de uma data completa que foi informada pelo usuario?
// digitamos "." após .Now ou .Today e temos acessos a dados especificos como dia, mês, hora, etc
// vou mostrar no exemplo:

// Aqui, eu não vou comparar o ano, não vou comparar o mês, apenas pegarei o dia "24" para ser comparado,
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


// Algo muito importante a ser considerado ao trabalhar com datas é como comparar o dia da semana.
// Quando você quer verificar se um determinado dia é uma segunda-feira ou qualquer outro dia da semana, 
// você precisa usar a propriedade DayOfWeek do DateTime.

// Ao invés de tentar comparar duas datas como se fossem iguais (exemplo: `DateTime.Now.DayOfWeek.Monday == DateTime.Now.DayOfWeek.Friday`), 
// o correto, é no primeiro argumento, colocar apenas "variavel".DayOfWeek (como `contratacao.DayOfWeek`), 
// e no segundo argumento, colocamos apenas o DayOfWeek com o dia da semana que queremos comparar (exemplo: `DayOfWeek.Monday`).

// Ou seja, você está perguntando: 
// "O dia da semana da data da contratação é uma segunda-feira?"
    DateTime contratacao = new DateTime(2020, 11, 12);
    if (contratacao.DayOfWeek == DayOfWeek.Monday) ;


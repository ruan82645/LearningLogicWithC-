
// Como você já viu ou se lembra, a tipagem no SQL server as vezes é igual as outras linguagens e as vezes diferente.
// Nesse módulo vamos ver sobre cada tipo de dado que usamos para fazer cadastro de tabelas ou usar em outros lugares
// Aqui vai ter a explicação de cada tipo e sua representação nas outras linguagens se for diferente

// 1) Numéricos:

// INT:
// Armazena números inteiros.
// Exemplo: 1, 100, -42.

// BIGINT:
// Armazena números inteiros maiores (até 9.223.372.036.854.775.807). Ideal para grandes contagens.

// FLOAT:
// Armazena números de ponto flutuante, usados para valores decimais.
// Exemplo: 3.14, -0.001.

// DECIMAL(p, s):
// Armazena números decimais, onde "p" é o número total de dígitos que pode estar dentro do campo
// e "s" é o número de dígitos à direita do ponto decimal, a quantidade de decimais obrigatoria
// Exemplo: DECIMAL(10, 2) pode armazenar 12345678.90 ou 123.80
// Nesse caso, o número não pode ter 11 caracteres no total, mas pode ter menos.


// 2) Textos:

// string = VARCHAR(x):
// Armazena strings de comprimento variável com até x caracteres. Exemplo:
// VARCHAR(50) para nomes.
// posso ter nomes com comprimentos variados, mas até 50 caracteres

// CHAR(x):
// Armazena strings de comprimento fixo.
// Por exemplo, CHAR(10) sempre armazena 10 caracteres (com espaços adicionais, se necessário).
// Obrugatoriamente vai armazenar 10 caracteres de texto, não podendo ser menos e nem mais.

// TEXT:
// Armazena grandes quantidades de texto (até 2 GB).
// Útil para descrições ou comentários longos.


// 3) Booleanos

// BIT:
// Armazena valores booleanos (0 para falso e 1 para verdadeiro ou true e false também).
// Pode ser usado para indicar status (ex: Ativo/Inativo).

// 4) Datas e Horas:

// DATE:
// Armazena datas(sem hora).
// Exemplo: 2024 - 10 - 29.

// TIME: Armazena hora(sem data).
// Exemplo: 14:30:00.

// DATETIME:
// Armazena data e hora combinadas.
// Exemplo: 2024 - 10 - 29 14:30:00.

// TIMESTAMP:
// Semelhante ao DATETIME, mas também pode incluir informações sobre o fuso horário.
// Útil quando seu servidor depender de alguma coisa que varie conforme usuarios de outro fuso acessem
// digamos que a pessoa cadastrou o aniversario dela. uma mensagem pode aparecer para ela na hora do nascimento
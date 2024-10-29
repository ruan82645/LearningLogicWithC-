
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
// Armazena números decimais com precisão fixa, onde "p" é o número total de dígitos dentro do campo
// e "s" é o número de dígitos à direita do ponto decimal, a quantidade de decimais obrigatoria
// Exemplo: DECIMAL(10, 2) pode armazenar 12345678.90
// Nesse caso, o número não pode ter 11 ou 9 caracteres no total e nem ter 1 ou 3 casas decimais
// tudo que entrar nesse campo deve ter exatamente 8 caracteres antes do ponto e 2 decimais depois do ponto
/*
--------------------------------------------------------------------------------------------------------------------------

ATENÇÃO - ATENÇÃO - ATENÇÃO - ATENÇÃO - ATENÇÃO - ATENÇÃO - ATENÇÃO - ATENÇÃO - ATENÇÃO - ATENÇÃO - ATENÇÃO - ATENÇÃO -

--------------------------------------------------------------------------------------------------------------------------

SE EXECUTARMOS O DELETE SEM SELECIONAR QUEM EM ESPECIFICO SERÁ DELETADO... 
TODOS, EU REPITO, TODOS OS CAMPOS SERÃO APAGADOS,
VOCÊ VAI DESTRUIT TODOS OS IDS SEM EXCESSÃO, ENTÃO MUITO, MUITO, MUITO CUIDADO.
JAMAIS ESQUEÇA O WHERE NA HORA DE ESCOLHER QUEM DELETAR
--------------------------------------------------------------------------------------------------------------------------

O comando Delete é o mais simples até o momento, tendo apenas 2 linhas principais

primeiramente escrevemos "delete from" e o nome da tabela, logo em seguida colocamos o Where e aplicamos o filtro.
Lembrando que podemos apagar desde um um unico id em especifico como todos os ids que contenham algo em comum

(
    Delete
        from clientes
    Where
        id_cliente = 125
)

ou...

(
    Delete
        from clientes
    Where
        email like '%gamil.com'
)

*/
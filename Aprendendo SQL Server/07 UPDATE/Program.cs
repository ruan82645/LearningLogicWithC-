/*
--------------------------------------------------------------------------------------------------------------------------

ATENÇÃO - ATENÇÃO - ATENÇÃO - ATENÇÃO - ATENÇÃO - ATENÇÃO - ATENÇÃO - ATENÇÃO - ATENÇÃO - ATENÇÃO - ATENÇÃO - ATENÇÃO - 

--------------------------------------------------------------------------------------------------------------------------

SE EXECUTARMOS O UPDATE SEM SELECIONAR QUEM EM ESPECIFICO SERÁ ATUALIZADO... 
TODOS, EU REPITO, TODOS SERÃO ATUALIZADOS COM OS DADOS ESCOLHIDOS,
VOCÊ VAI ATUALIZAR TODOS OS IDS SEM EXCESSÃO, ENTÃO MUITO, MUITO, MUITO CUIDADO.
JAMAIS ESQUEÇA O WHERE NA HORA DE ESCOLHER QUEM ATUALIZAR
--------------------------------------------------------------------------------------------------------------------------

O comando Update no sql serve justamente para atualizar campos de um id já existente.

Ele tembém é muito simples e um pouco diferente de como se usa o insert.

Logo de cara, a primeira coisa a ser feita é selecionar qual tabela vamos usar,
e fazemos isso da seguinte forma:

(
"Update "tabela" set"
)

isso indica que após escrever a tabela, vamos "setar" novos valores para os alvos de nossa escolha.

E agora para atualizar? é bem mais simples que em insert, bastando dizer qual o campo e colocando seu valor logo em seguida

(
Update cliente set
    telefone = '61 98185-3151',
    rg = '6556568'
)

Certo, é bem simples, mas agora precisamos escolher quem vai ser o alvo da atualização
e para isso usamos o Where, que é onde colocamos o filtro para dizer quem vamos atualizar.

Nomalmente a atualização é feita por id, dizendo qual o valor de id que queremos alterar,
porém também podemos colocar filtros a vontade como qualquer outro... atualizar todos que tenham certo email,
ou que morem em tal lugar, etc

(
Update cliente set

    telefone = '61 98185-3151',
    rg = '6556568'

Where
    
    id_cliente = 12
)

e pronto, simples assim foi atualizado. Porém tem algo muito importante para saber...


 */

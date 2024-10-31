
/*
 
Nesse módulo vamos falar sobre o uso mais avançado do Select, algumas funções diferentes e principalmente sobre-
SUBQUERY

Primeiramente, o que é uma subquery(subconsulta)?

Subquery é o ato de fazer consulta dentro de conusulta (select dentro do primeiro select) para criar contas mais complexas
e trazer colunas novas com resultados personalizados por você mesmo.
Como assim? imagine que você selecionou todas as suas lojas da tabela lojas... vai ser exibido para você os dados que-
já estavam na tabela normalmente, o nome da loja e o id da loja por exemplo... Mas vamos supor que nessa busca, você queira-
exibir a quantidade de pedidos de cada loja. Na tabela de pedidos, tem listado bonitinho cada pedido, porém-
lá não tem um campo onde diz quantos pedidos foram feitos em cada loja. Para fazer isso, precisariamos fazer um novo select-
dentro daquele primeiro select inicial que pegava os dados das lojas.

É um pouco confuso de primeira, mas imagine algo assim:

(Select * from Lojas)
----- Aqui, trazemos todos os dados que estão apenas em lojas

("Select Loja_id, Loja_name,
    (Select [conta de matematica envolvendo outra tabela]) as total de pedidos,
    (Select [conta de matematica envolvendo outra tabela]) as total de vendas,
    (Select [conta de matematica envolvendo outra tabela]) as média por venda
From Lojas where loja_id = 1 )
----- Aqui, nós criamos três novas colunas, onde cada Select repesenta um calculo envolvendo dados de outra tabela,
      no final, teremos duas colunas originais da tabela loja, mais 3 colunas novas que você criou o calculo la dentro





 */

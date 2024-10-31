
/*
 
Nesse módulo vamos falar sobre o uso mais avançado do Select, algumas funções diferentes e principalmente sobre-
SUBQUERY

-----------------------------------------------------------------------------------------------------------------------------
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

---------------------------------------------------------------------------------------------------------------------------
Antes de irmos para quais tipos de contas podemos fazer e quais os operadores para isso-
eu primeiro vou explicar como fazer para contar quantas linhas existem em uma tabela,
após isso vou mostrar um método vai ser necessário em muitas contas, mas para entende-lo, 
primeiramente precisa entender isso para que tenhamos um exemplo para o proximo

COUNT: 

      O COUNT é uma função que conta quantas linhas existem em uma tabela. 
      É importante não confundir isso com a contagem de valores em colunas individuais.
      Quando usamos COUNT, estamos nos referindo ao número total de linhas de um conjunto de dados.

      Por exemplo, imagine uma tabela que possui 10 colunas e 5 linhas. 
      Se você usar COUNT sem nenhum filtro, o resultado será 5, pois há 5 linhas no total dessas 10 colunas

      Agora, se você quiser contar quantas dessas linhas pertencem a uma loja específica, digamos a loja com ID 2, 
      você pode aplicar um filtro. Nesse caso, se das 5 linhas, 3 forem relacionadas à loja 2,
      o COUNT com o filtro resultará em 3. Isso mostra quantas vezes a loja 2 aparece na tabela de pedidos.

a estrutura para usar ele é "select Count("*" ou "uma coluna em especifico") from "tabela"
      
Dessa forma ele fará uma conta geral de tudo que tiver lá e vai retornar esse resultado.
Mas imagine comigo novamente o exemplo de trazer quantos pedidos tivemos em cada loja,
se apenas executassemos essa subquery, ele exibiria o mesmo resultado para todas as lojas,
afinal, não dissemos que na primeira contagem ele conte os pedidos da loja 1, na segunda ele conte a da loja 2...

Antes de mostrar como podemos usar um filtro assim, precisamos entender como o SQL se comporta ao trazer os dados para nós.





Inner join serve para unir as informações de duas planilhas através de algo que as duas tenham em comum.
Mas pra que isso e como assim algo em comum?

Digamos que para fazer uma conta de somar qual o valor total vendido de uma unica loja, nós precisamos de uma lista-
onde tenha o valor de cada pedido, certo? 






 */

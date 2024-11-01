
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
quando selecionamos quais campos desejamos trazer de uma tabela, o Sql faz como um foreach,
para cada tabela, vou trazer esses resultados e tudo relacionado a ele... 
Então primeiro ele executa e traz os dados da linha 1,
depois ele executa de novo e traz os dados da linha 2 e assim por diante até acabar. 
Concorda comigo que se a cada "iteração", a linha é sobre uma loja diferente(um produto diferente)
o id desse produto atual var ser diferente a cada iteração? 

primeira iteração:
         | id_loja = 1 | loja_nome = carrefour | local_loja = Brasilia |
segunda iteração:
         | id_loja = 2 | loja_nome = Pão de açucar | local_loja = São Paulo |

Se a cada iteração o id muda, e a outra tabela que usamos o count também possui id_loja para se conectarem,
concorda que podemos aplicar um filtro para fazer ele contar +1 a cada vez que a venda atual-
tiver o mesmo id da loja que está iterando no momento?

ele agora estaria iterando sobre a loja com id-1, então ele pegaria e contaria todos que tivessem o id-1 e passaria a bola,
depois estaria iterando sobre a loja com id-2, então ele pegaria e contaria todos que tivessem o id-2

Ok, e como eu faria isso em código? 

"Select 
Loja_id,
Loja_nome,
    (select count(*) from pedidos where pedidos.Loja_id = Lojas.Loja_id) as pedidos_por_Loja
From
   Lojas"

    a tabela pedido tem o Loja_id para sabermos de qual loja veio cada pedido, e agora pensa comigo:
na primeira iteração, estamos passando pelo Lojas.Loja_id que é 1 no momento,
quando chega no count lá na tabela pedidos, ele olha e pensa, "vou contar só quem tiver loja_id = 1 nessa tabela..."
e retorna esse número
    na proxima ele vai pensar "ok, agora eu conto todo mundo que tiver loja_id = 2 nessa tabela..."

-------------------------------------------------------------------------------------------------------------------------
INNER JOIN:

Ok... Eu sei que explicação de Count foi longa e chata, mas você precisava entender o conceito de iteração no sql
e de como cada tabela as vezes tem um id em comum com outra tabela, e que com isso podemos usar as duas para calcular coisas

Mas... E se por acaso quisessemos calcular o total de vendas de cada loja, a soma do dinheiro mesmo,
e o id da tabela de referencia que voce está usando não tem na tabela onde mostra as vendas?

vamos voltar novamente para o exemplos das Lojas... A tabela lojas tem loja_id, assim como a tabela pedidos também tem,
é assim que identificamos de onde vem cada um, 
porém essa tabela pedidos, mostra apenas: a data, o cliente, o id da loja e o id dos itens do pedido?
os valores não estão lá, na verdade em cada pedido temos um id que leva para outra tabela,
e lá sim tem o preço do que foi pedido?

concorda comigo que a tabela Lojas leva para a tabela pedidos e pedidos leva para a tabela itens do pedido?

eu quero calcular o quanto foi vendido em cada loja, pra isso eu preciso do campo de valores de itens do pedido,
mas itens do pedido não tem loja_id, então não posso fazer aquele filtro onde o id atual é igual ao que está sendo procurado

pra resolver isso, eu teria que ligar os dados da tabela pedidos aos dados da tabela itens do pedido,
eu preciso transformar elas em um, pois assim, eu teria o loja_id na mesma tabela onde tenho o preço de cada pedido

É pra isso que temos o INNER JOIN, ele serve para unir duas tabelas para que tenhamos todos os dados em uma unica,
para usar ele, precisamos escolher quem desejamos unir a tabela da conta atual e dizer o que amobs tem em comum

digamos que as duas tabelas tenham "pedido_id", é isso que elas tem em comum, o id de uma é igual o id da outra

Sua estrutura é (""contaMatematica(...)" from "tabela1" inner join "tabela2" on "tabela1".id_igual = "tabela2".id_igual")

com base nisso, vamos fazer então a união de ambas e fazer a soma de cada loja

("Select id_loja,nome_loja,
       (select soma(price) from Detalhes_pedido
        inner join Pedido on Detalhes_pedido.id_pedido = Pedido.id_pedido
        where pedido.id_loja = Lojas.id_loja) as total vendido
From Lojas)

"Selecione a soma dos preços na tabela 'Detalhes_pedido', 
onde o 'id' da loja na tabela 'Pedido' corresponda ao 'id' da loja na tabela 'Lojas' que estamos analisando no momento."
--------------------------------------------------------------------------------------------------------------------------
AGORA SIM, OPERADORES DE CALCULO!!

todos os operadores que vou mostrar, tem exatamente a mesma sintaxe, então se entendermos suas estruturas,
vamos saber utilizar todos eles sem problema algum!

Eles são: 

SUM()-soma,
AVG()-média,
MAX()-maior valor,
MIN()-menor valor

Como usar eles? em uma SubQuery, selecionamos o operador matemático e qual coluna vamos calcular, depois de onde vem essa coluna
 --- Select Sum(preço) from pedidos 
Após isso, podemos aplicar filtros normalmente, usar o inner join, where, o que quisermos e dar nome para a tabela gerada

| Preço  | n_pedido | id_pedido | id_loja |  |   traga a soma do valor de cada loja, a média de valor de cada uma,
-------------------------------------------  |   maior valor e menor valor de cada uma
| 450,00 | pedido 1 |     1     |    2    |  |
| 200,00 | pedido 2 |     2     |    1    |  | Select id_loja, nome_loja
| 10,50  | pedido 3 |     3     |    2    |  |    (select sum(preço) from pedido where pedido.id_loja = lojas.id_loja) as soma,
| 320,00 | pedido 1 |     4     |    2    |  |    (select avg(preço) from pedido where pedido.id_loja = lojas.id_loja) as media,
| 300,00 | pedido 2 |     5     |    3    |  |    (select max(preço) from pedido where pedido.id_loja = lojas.id_loja) as maior,
| 17,80  | pedido 3 |     6     |    1    |  |    (select min(preço) from pedido where pedido.id_loja = lojas.id_loja) as menor
| 450,00 | pedido 1 |     7     |    3    |  | From Lojas
| 200,00 | pedido 2 |     8     |    2    |  |    
| 16,50  | pedido 3 |     9     |    1    |  |    RESULTADO:

                                                 | id_loja | nome_loja | soma   | media  | maior  | menor  |
                                                 ------------------------------------------------------
                                                 |    1    | Brasilia  | 227,00 | 75,67  | 200,00 | 10,50  |
                                                 |    2    | São Paulo | 770,00 | 385,00 | 450,00 | 320,00 |
                                                 |    3    | Tocantins | 917,80 | 305,93 | 450,00 | 17,80  |
                                                 
                                               

 */

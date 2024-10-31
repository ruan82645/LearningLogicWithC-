
/*
 
Nesse módulo vamos falar sobre o uso mais avançado do Select, algumas funções diferentes e principalmente sobre-
SUBQUERY

Primeiramente, o que é uma subquery(subconsulta)?

Subquery é o ato de dentro da seleção de quais campos vamos exibir, antes de selecionarmos de qual tabela pegamos os dados,
adicionar mais conjuntos de select junto com comandos especiais, que permitem criar colunas personalizadas.
Como assim? imagine que você selecionou todas as suas lojas da tabela lojas... vai ser exibido para você os dados que-
já estavam na tabela normalmente, o nome da loja e o id da loja por exemplo... Mas vamos supor que nessa busca, você queira-
exibir a quantidade de pedidos de cada loja. Na tabela de pedidos, tem listado bonitinho cada pedido, porém-
lá não tem um campo onde diz quantos pedidos foram feitos em cada loja. Para fazer isso, precisariamos criar uma nova coluna
na nossa busca la do inicio quando puxamos os dados da loja. Mas fazemos isso dentro do campo select, olha a imagem abaixo:
 
 */

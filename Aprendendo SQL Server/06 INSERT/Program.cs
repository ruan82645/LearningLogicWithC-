/*
O Comando Insert no Sql serve para adicionar dados manualmente em uma tabela especifica.
 Nós selecionamos a tabela, dizemos quais campos queremos preencher e entrão quais informações vamos colocar dentro dela

 O comando Insert é extremamente simples e intuítivo também, porém devo lembrar uma coisa.

 Quando criamos uma tabela, ou na maioria das tabelas já prontas, existe a função de incrementar o id automaticamente,
então se na tabela que deseja incluir tiver essa opção ativa(vai ter o icona de chave ao lado), toda vez que algo entrar lá,
será automaticamente adicionado um novo id, sem depender de você! Então mesmo que queiramos escrever o id ao colocar manualmente,
nós não possuimos permissão, vai dar erro. Todo o restante é preenchivel, menos o ID

Certo, vamos para como funciona o comando então:

primeiro selecionamos a qual tabela vamos inserir os dados, dessa forma:

(INSERT INTO "TABELA")

e então abrimos chaves. E dentro dessas chaves dizemos quais campos vamos usar para inserir os valores.
Vale lembrar que nem sempre todos campos são obrigátorios, mas devemos verificar se são, pois se for obrigatorio e não o citarmos-
haverá erro!

Insert into CLIENTES
(
nome, 
sobrenome,
idade,
endereco 
)

após dizemos quais os campos serão preenchidos, colocamos "Values" e abrimos novamente os parenteses-
e dentro deles preenchemos os dados...
Sempre na mesma ordem na qual declaramos os campos, então se o primeiro campo é nome, o primeiro valor será nome

Insert into CLIENTES

(
nome, 
sobrenome,
idade,
endereco 
)

Values
(
'ruan' ,
'alves' ,
20 ,
''
)

note que deixei o endereço em branco usando string vazia. Caso esse campo fosse obrigatório e eu não soubesse o que colocar, -
eu poderia colocar string vazia, afinal, são dados diferentes

*/
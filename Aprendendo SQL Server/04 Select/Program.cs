
// Nesse Módulo, vamos entender melhor o que é, quais funções, modos de uso e por existe o Select.
// E uma novidade que coloquei, imagens para ajudar na compreensão!! Abra os links para ver as imagens

// Quando temos um banco de dados com muitas informações, com certeza teremos varias tabelas, cada uma organizada
// porém as vezes precisamos fazer filtragens dentro de uma unica tabela ou mais.
// por exemplo: pegar somente os nomes de quem tem Hotmail na tabela de clientes
// ou mesclar informações especificas de varias tabelas diferentes para vizualizar os dados de melhor forma

// "Ah, o gerente pediu para filtrar os dados das vendas da semana passada dos carros da Chevrolet"

// Quando estamos olhando uma tabela, vemos como uma página de excel, aparecem as colunas e dados que escrevemos lá
// mas assim como no excel, as vezes de 10 tipos de informação, queremos ver apenas 3, ou ver dados de pessoas especificas.
// Imagine que em uma aba, temos informações de pedidos, já em outra de clientes. E eu quero saber quais pessoas-
// compraram uma determinada bicicleta, para isso, eu pegaria as informações de pedido e juntaria com os clientes
// assim eu formaria um "aba nova" com os dados que EU quero analisar ou utilizar

// Mas diferente do Excel, não fazemos isso apenas com o mouse, devemos fazer por uma linha de código.
// Ela é extremamente simples e é escrita da mesma forma que escrevemos na vida real.
// Esse é o Select, um comando que seleciona informações que você deseja vizualisar e exibe para você na tabela abaixo

// Quando selecionamos ver as linhas de uma tabela especifica, serão exibidas as informações na parte inferior da tela.
// Enquanto em cima possuímos um campo onde podemos escrever livremente, e é lá que podemos digitar nossos códigos,
// nesse caso, o Select. Podemos escolher qualquer tabela, afinal, como podemos puxar informações a vontade de qualquer uma,-
// não tem problema, mesmo que eu esteja na tabela de clientes, eu posso com o select ver somente sobre pedidos ou produtos.

//---------------------------------------------------------------------------------------------------------------------------

//  COMO FUNCIONA O SELECT?

// Como mencionado antes, quando escrevemos algo com ele, é como se escrevessemos ou falassemos na vida real.
// A sua pronuncia é extremamente simples e didática, vou dar um exemplo...

// Imagine que quero exibir somente o nome das pessoas que tenham mais de 25 anos da tabela "clientes"
// Select "nome" from "clientes" where idade > 25
// "selecione nome de clientes onde idade seja maior que 25"

// eu primeiro seleciono quais campos eu quero trazer("nome"), após isso digo de onde eu devo puxar esses campos("clientes"),
// e por ultimo, eu digo qual é o filtro que quero usar, nesse caso somente quem tiver valor maior que 25 no campo "idade"

// Claro que existem muitas funções e formas de escrever também, vamos entrar em cada uma para facilitar.
// Essas funções vão desde selecionar todos os campos de uma tabela, juntar informações de varios campos em uma linha só,
// aplicar filtros de coisas que começem ou terminem com algo especifico, usar operadores lógicos como:
// "se uma dessas informações bater E essa outra bater também, exiba pra mim". 

// Vamos separar aqui em tópicos para entedermos melhor a estrutura

//--------------------------------------------------------------------------------------------------------------------------

// Estrutura simples:

// Vamos nos lembrar ao menos da sintaxe simples do Select, que seria " *Select* blabla *from* blabla *where* blabla = blabla " 

// TABELAS:

//         Colchetes: muitas vezes veremos nomes de tabelas ou campos entre colchetes, isso não é obrigatório.
//                    É uma forma do SQL separar um possivel nome reservado pelo sistema do nome que está lá.
//                    Imagine que "name" já está reservado, se voce usar o "select name" daria erro, pois a palavra está reservada,
//                    agora se usassemos "select [name]", daria certo. Mas lembrando, não é uma obrigação,
//                    se voce sabe que as coisas escritas lá não são reservadas, pode escrever sem eles!!!
//                    imagem de referencia: https://postimg.cc/ppKs2SZk

//     Aspas Simples: No Sql, além de strings serem representadas por aspas simples e não duplas, ela também tem outro uso.
//                    se após o select, antes ou depois de selecionar uma coluna real, colocarmos algo dentro de aspas simples,
//                    como uma palavra ou um nome. Será formada uma nova coluna apenas com aquilo que escreveu repetidamente.
//                    também podemos nomear essa coluna colocando "as nomeColuna".
//                    Ou seja... "Select [nomes], 'Alves' as sobrenomes from..." (isso quer dizer, selecione a coluna nomes-
//                    e forme uma ao lado chamada sobrenome com a palavra "Alves" em cada linha
                        



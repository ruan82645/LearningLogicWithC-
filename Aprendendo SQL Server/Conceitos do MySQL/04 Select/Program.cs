﻿/*
 

// SELECT BÁSICO

Nesse Módulo, vamos entender melhor o que é, quais funções, modos de uso e por existe o Select.
 E uma novidade que coloquei, imagens para ajudar na compreensão!! Abra os links para ver as imagens

 Quando temos um banco de dados com muitas informações, com certeza teremos varias tabelas, cada uma organizada
 porém as vezes precisamos fazer filtragens dentro de uma unica tabela ou mais.
 por exemplo: pegar somente os nomes de quem tem Hotmail na tabela de clientes
 ou mesclar informações especificas de varias tabelas diferentes para vizualizar os dados de melhor forma

 "Ah, o gerente pediu para filtrar os dados das vendas da semana passada dos carros da Chevrolet"

 Quando estamos olhando uma tabela, vemos como uma página de excel, aparecem as colunas e dados que escrevemos lá
 mas assim como no excel, as vezes de 10 tipos de informação, queremos ver apenas 3, ou ver dados de pessoas especificas.
 Imagine que em uma aba, temos informações de pedidos, já em outra de clientes. E eu quero saber quais pessoas-
 compraram uma determinada bicicleta, para isso, eu pegaria as informações de pedido e juntaria com os clientes
 assim eu formaria um "aba nova" com os dados que EU quero analisar ou utilizar

 Mas diferente do Excel, não fazemos isso apenas com o mouse, devemos fazer por uma linha de código.
 Ela é extremamente simples e é escrita da mesma forma que escrevemos na vida real.
 Esse é o Select, um comando que seleciona informações que você deseja vizualisar e exibe para você na tabela abaixo

 Quando selecionamos ver as linhas de uma tabela especifica, serão exibidas as informações na parte inferior da tela.
 Enquanto em cima possuímos um campo onde podemos escrever livremente, e é lá que podemos digitar nossos códigos,
 nesse caso, o Select. Podemos escolher qualquer tabela, afinal, como podemos puxar informações a vontade de qualquer uma,-
 não tem problema, mesmo que eu esteja na tabela de clientes, eu posso com o select ver somente sobre pedidos ou produtos.

---------------------------------------------------------------------------------------------------------------------------

  COMO FUNCIONA O SELECT?

 Como mencionado antes, quando escrevemos algo com ele, é como se escrevessemos ou falassemos na vida real.
 A sua pronuncia é extremamente simples e didática, vou dar um exemplo...

 Imagine que quero exibir somente o nome das pessoas que tenham mais de 25 anos da tabela "clientes"
 Select "nome" from "clientes" where idade > 25
 "selecione nome de clientes onde idade seja maior que 25"

 eu primeiro seleciono quais campos eu quero trazer("nome"), após isso digo de onde eu devo puxar esses campos("clientes"),
 e por ultimo, eu digo qual é o filtro que quero usar, nesse caso somente quem tiver valor maior que 25 no campo "idade"

 Claro que existem muitas funções e formas de escrever também, vamos entrar em cada uma para facilitar.
 Essas funções vão desde selecionar todos os campos de uma tabela, juntar informações de varios campos em uma linha só,
 aplicar filtros de coisas que começem ou terminem com algo especifico, usar operadores lógicos como:
 "se uma dessas informações bater E essa outra bater também, exiba pra mim".

 Vamos separar aqui em tópicos para entedermos melhor a estrutura

--------------------------------------------------------------------------------------------------------------------------

 ESTRUTURA SIMPLES:

 Vamos nos lembrar ao menos da sintaxe simples do Select, que seria " *Select* blabla *from* blabla *where* blabla = blabla " 
-------------------------------------------------------
 CAMPOS (COLUNAS):

         Colchetes: muitas vezes veremos nomes de tabelas ou campos entre colchetes, isso não é obrigatório.
                    É uma forma do SQL separar um possivel nome reservado pelo sistema do nome que está lá.
                    Imagine que "name" já está reservado, se voce usar o "select name" daria erro, pois a palavra está reservada,
                    agora se usassemos "select [name]", daria certo. Mas lembrando, não é uma obrigação,
                    se voce sabe que as coisas escritas lá não são reservadas, pode escrever sem eles!!!
                       (imagem de referencia: https://postimg.cc/ppKs2SZk)


         Aspas Simples: No Sql, além de strings serem representadas por aspas simples e não duplas, ela também tem outro uso.
                        se após o select, antes ou depois de selecionar uma coluna real, colocarmos algo dentro de aspas simples,
                        como uma palavra ou um nome. Será formada uma nova coluna apenas com aquilo que escreveu repetidamente.
                        também podemos nomear essa coluna colocando "as nomeColuna".
                        Ou seja... "Select [nomes], 'Alves' as sobrenomes from..." (isso quer dizer, selecione a coluna nomes-
                        e forme uma ao lado chamada sobrenome com a palavra "Alves" em cada linha!)
                           (imagem de referencia: https://postimg.cc/0zMWTN4M)   
                           (imagem de referencia: https://postimg.cc/CnxJmMDK)   


         Unir dois campos: As vezes queremos unir dois campos em um único, como por exemplo nome e sobrenome,
                           idade e ano de nascimento, função do trabalho e data de contratação, etc...
                           Se quisermos pegar esses dois e formar um campo novo onde duas informações se encontrem juntas,
                           podemos fazer da seguinte forma: após o select para selecionar a coluna, abrimos parenteses e-
                           concatenamos os nomes das duas colunas com um +, por exemplo: (nome + ' ' + sobrenome).
                           a concatenação é igual das outras linguagens, colocamos vazio para espaço e tudo mais...
                           Após isso, se quisermos, podemos nomear essa nova coluna com um "as nomeColuna"
                              (imagem de referencia: https://postimg.cc/7JJ9pssv)

-------------------------------------------------------
 TABELAS:

         Apelidos: imagine uma pesquisa onde tenhamos que filtrar MUITOS dados, isso geraria uma pesquisa longa
                   com muitas linhas, e muitas delas estariam se referenciando a uma tabela, outras à outras tabelas,
                   outras colunas, isso torna confuso de se olhar a primeira vista. É para isso que servem os apelidos,
                   é uma forma de você dar um apelido a uma tabela. Esse apelido pode ser usado juntamente-
                   de quando selecionamos uma campo, dessa forma nós vamos ver o apelido atrás do campo e identificar
                   "ah... esse campo é dessa tabela aqui".
                   Para criar um apelido, nós apenas devemos escrever como queremos apelidar a tabela ao lado do nome real dela,
                   sem string sem nada ("from Customers clientes") agora o apelido de Customers é clientes, mas como usamos ele?
                   o apelido é apenas uma nomeação para colocar antes de um campo, apenas para organizar,
                   e fazemos isso dessa forma: (select clientes.First_Name from Customers clientes).
                   Não sugiro colocar apelidos ruins ou que não tenham haver com a tabela real, deixe algo parecido.
                      (imagem de referencia: https://postimg.cc/w3tkTBH9)
                      (imagem de referencia: https://postimg.cc/3WDgQbCR)
                      (imagem de referencia: https://postimg.cc/CzGkzB2p)

-------------------------------------------------------
 WHERE:

 A cláusula WHERE é usada para filtrar os resultados com base em condições.
 Somente os registros que atendem à condição especificada serão incluídos no resultado.
 O que digitamos após o where é o que desejamos recebeber daquela coluna, daquela tabela.
                            
         AND: Como seu proprio nome já diz: "e". Ele é o substituto do "&" aqui em SQL, quando queremos nos referir a algo
              e mais alguma coisa, usamos o and normalmente como se escrevessemos na vida real (where isso and aquilo)
                 (imagem para referencia: https://postimg.cc/TpYVKjzM)


         OR: Também sendo bem auto explicativo, o "or" substitui o "||" dentro do SQL, tranzendo multiplas informações-
             com base no seu filtro
                (imagem para referencia: https://postimg.cc/Ln1HBGKz)
                

         Condições Booleanas: O Where pode ser usado como um if para criar uma verificação que diz se a condição é true ou false
                              Mas como isso acontece? Como dito antes aqui, podemos fazer coisas como: "Where idade = 15", ou
                              "Where cargo = gerente". Quer dizer que ele só me tratá os resultados da pessoa que tiver 15 anos,
                              ou no outro caso, só vai me trazer o resultado de quem for gerente. Mas eu posso unir ambas!
                              Diferente das outras linguagens que usamos "|| e &", aqui nós escrevemos "or e and".
                              Se eu escrever "Where idade > 35 and cargo = gerente", os resultados que forem true, vão vir,
                              e pronto, essa é minha lista de possiveis novos diretores. Mas e se eu quiser misturar or e and?
                              Podemos fazer isso separando as verificações, colocando por exemplo uma verificação "or"-
                              dentro de um parente e um "and" fora, dessa forma ele verifica se uma das condições é true,
                              se ela for, aí sim ele verifica se "and" bate, se sim, vai trazer o resultado.
                                 (imagem para referencia: https://postimg.cc/Ty20Jqb6)


         BETWEEN: O Between serve para filtrar dados que estejam entre um determinado filtro colocado.
                  Ele não retorna apenas resultados númericos, mas também podemos usa-lo para Datas e strings,
                  embora strings, ele sempre separe por ordem alfabética. Mas como funciona? Para usa ele-
                  escrevemos o Where, então a coluna de onde queremos puxar os dados, aí colocamos o Between
                  seguido de onde queremos o resultado até onde queremos(usando o and no meio deles)
                  "where Clinte_ID between 7 and 15"
                     (imagem para referencia: https://postimg.cc/06mWVd5X)


         Like: Like é usado para fazer pesquisas de acordo com um padrão que você vai estabelecer em uma-
               coluna de texto, ela serve para pesquisar por uma palavra em especifico, se o texto
               começa com certos caracteres, se termina com certos caracteres, se tem certos caracteres no meio do texto...
               (where Nomes_Cliente like 'Janderson') "traga as informações de quem se chamar Janderson".
               Like é comumente acompanhado de operadores como "%" e "_" e vou explicar para que serve cada um desses.
                  https://postimg.cc/w1bMwL4N
                       "%" significa "qualquer texto", e dependendo de onde você o coloca dentro do padrão, significa uma coisa.
               Se colocado antes da plavra de pesquisa, como: (like '%gmail.com') vai significar "...@gmail.com", ele traz-
               quem terminar com aquela palavra ou caracter, mas se colocarmos no final por exemplo: (like 'rib%'), ele traz-
               quem começar com rib, sem se importar com vem depois. Também podemos usar em ambas as pontas-
               ou fazer diversas combinações: (like '%ado%'), (like 'tec%vivo%ando'), esses são exemplos onde o primeiro-
               deve ter "ado" no meio da palavra, enquanto o outro deve conter "tec,vivo,ando" dentro da plavra.
                  https://postimg.cc/crSn3RP4
                  https://postimg.cc/yD63QVVM
                  https://postimg.cc/QF69vRCH
                       "_" representa um unico caracter, pode ser qualquer um, mas apenas um por "_", então se eu coloco:
               (like '61 9________') ele vai me trazer quem começa com "61 9", mas quem tem exatos 8 digitos após
                  https://postimg.cc/nMZmjKyV
                  https://postimg.cc/LYv8ZPPh
                  https://postimg.cc/ZvRKPqPH
                   
            
         IS, IS NOT: Esse operador simples e tem basicamente um unico uso... retornar dados onde uma coluna seja nula ou não.
                     Imagine a tebela de clientes de sempre, nessa tabela, existem clientes que deixaram o telefone em branco
                     e você deseja mandar um email para todas essas pessoas que não preencheram esse dado, pedindo para colocarem.
                     Quando vamos solicitar os dados, verificamos quem é nulo ou não é nulo e ele nos traz os clientes certos.
                     por exemplo (where telefones is null), ou (where telefone is not null)
                        https://postimg.cc/Z9bRYj9X
                        https://postimg.cc/t1BgsPWJ

        
         ORDER BY: O operador ORDER BY é utilizado para ordenar os resultados de uma consulta SQL. 
                   Ele é normalmente usado após aplicar filtros com outros operadores, como o List, =, is, etc.
                   Ele vai sempre no final da consulta que acabou de ser feita, sendo a ultima linha
                   Por exemplo, se você estiver filtrando nomes que começam com a letra "B", 
                    você pode usar ORDER BY para organizar esses resultados selecionando uma coluna específica, 
                    como o nome ou a data. 
                    Você pode escolher se deseja que a ordenação seja em ordem crescente ou decrescente.
                    (where idade > 35 order by Nome desc) - aqui nesse exemplo, ele traz todos maiores de 35 anos,
                    depois disso eu escolhi a coluna Nome como referencia e usei o order by para listar todos em decrescente.
                    (where idade > 35 order by Nome) - a mesma coisa, porem vai ser em ordem crescente(alfabetica)
                       https://postimg.cc/ZBm1zDCy
                       https://postimg.cc/WF7xN6kY
                              


*/
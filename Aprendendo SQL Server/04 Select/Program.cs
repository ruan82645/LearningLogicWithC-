/*
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


                    
        
                              


*/
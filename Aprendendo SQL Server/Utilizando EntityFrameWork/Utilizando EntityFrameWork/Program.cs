/*
 
 O QUE É O ENTIITY FRAMEWORK?

    EntityFrameWork é uma ORM(Mapeamento de Objeto Relacional) que serve para facilitar o uso em diversos tipos de bancos de dados,
desde o SQL Server como vários outros. Mas o que significa ORM? ORM é como uma biblioteca que já está fazendo a organização-
para o usuario de todos os comandos e como eles vão se relacionar com o Sql.

    Não precisamos ficar escrevendo Querys repetitivamente para trazer certos dados ou ficar nos preocupando com os tratamentos-
de erros, pois o próprio Entity faz isso. Nós apenas pedimos algo e ele faz a execução completa, sem necessidade de dezenas
de linhas de codigo para algo simples como é feito no System.Data

    Ele é como o React, pense como se fosse uma biblioteca que tem diversas funções para facilitar coisas que precisavam de-
muitas linhas de codigo no JavaScript padrão, quando usamos um UseState lá, ele já entende que o que lá dentro vai mudar e como-
vai mudar, depois apenas atribuimos o seu valor e como ele vai funcionar, mas ele vai cuidar de todo o resto

    Imagine a seguinte situação: Você se vira para Larissa e diz "compra 20 pães por favor". Quando dizemos isso-
não nos preocupamos em como será pago, nem em como ela vai chegar lá, nem se vai ter fila, ou se vai acontecer algo. Nós-
sabemos que em algum tempo ela aparecerá com os 20 pães, e é justamente isso que o Entity Faz, não precisamos prever tudo-
para nos precaver escrevendo dezenas de códigos; Ele apenas vai e executa, resolvendo os proprios problemas

DATA-BASE FIRST VS CODE FIRST

    Existem duas formas de fazer o Entity se comunicar com o código C#, essas duas formas recebem esses nomes:-
DataBase First ou CodeFirst. Esses dois são comandos que damos inicialmente que faz a ligação entre ambos os programas.

    O DataBase First opera a partir de um banco de dados já existente, espelhando todo seu conteúdo dentro do C# automaticamente,
criando classes, e tudo para facilidade do usuário em acessar os dados.

    O CodeFirst seria recriar manualmente as classes e mapeamento de dados dentro do C# para aí sim podermos ligar os dois.
Por ser complexo e trabalhoso demais, não é o metodo mais utilizado.


    Aqui, usaremos apenas o DataBase First para fazer os programas


NUGETS:

    Para trabalhar com o Entity, nós usamos três Nugets, sendo um: O proprio Entity da Microsoft, o programa do nosso banco(-
pode ser SqlServer, MySql, PostGree, etc...), e o Design(ele que se encarrega de criar as classes por nós e fazer o mapemento)

Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer



 */
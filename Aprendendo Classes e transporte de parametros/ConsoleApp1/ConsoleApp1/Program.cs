
// Nesse módulo, vamos tentar compreender um pouco mais sobre os paramêtros.
// Mais especificamente sobre divisão de tarefas de um código em multiplas funções,
// Por boa prática e para facilitar a manutenção do códido, é necessário que cada método, possua uma unica função

// porém essa é a parte fácil de entender, a parte mais complicada é pensar em como se dividir,
// no caso a ordem das coisas até finalizar as divisoes e entender o que cada classe retorna e como transportar para outra.
// Vão ter pequenas explicações nesse módulo, a maior parte do aprendizado será em prática, fazendo e lendo os códigos ja feitos.


// Vamos para o básico... O que é NameSpace e como declarar as classes

// Quando criamos uma nova Classe, em outra página, há sempre um Namespace novo, que seria o que usamos com o "using",
// É basicamente o que acompanha a classe como pre fixo


// Tipos de coisas que podemos fazer com classes:
// As classes podem tanto armazenar dados para importar para outra classe,
// quanto processar os dados executando alguma função.
// 
// - Se precisarmos processar poucas informações, podemos passá-las diretamente entre funções.
// - Se estivermos lidando com muitos dados, como os de um arquivo, é mais eficiente salvar
//   essas informações em uma estrutura (como uma lista), para que possam ser usadas por outros métodos ou classes.
//
// Vamos imaginar um cenário onde temos um arquivo de dados, e cada linha possui informações de uma pessoa,
// como nome, telefone, email e CEP. Podemos usar três classes para organizar esse processo:
//
// 1. Uma classe para armazenar as informações de cada pessoa.
// 2. Outra classe para ler os dados do arquivo e armazená-los numa lista.
// 3. Uma terceira classe que utiliza essa lista para realizar alguma operação.
//
// O foco aqui será também explicar como funcionam os **retornos** em cada método.
// O retorno de um método define o **tipo de dado** que ele devolve para quem o chama.
// Isso é importante porque quando chamamos um método, o que recebemos dele pode ser usado para continuar o processamento.

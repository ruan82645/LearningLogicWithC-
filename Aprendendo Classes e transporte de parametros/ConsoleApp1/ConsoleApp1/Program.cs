
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
//
// Entendendo o funcionamento dos retornos entre métodos:
// Quando temos uma classe que lida com dados, é comum termos múltiplos métodos com diferentes responsabilidades.
// Vamos imaginar que o primeiro método de uma classe é responsável por ler e armazenar os dados em uma lista.
// Ele **retorna** essa lista, ou seja, devolve a lista para quem chamou o método.
// É isso que significa retornar, dizer que o usuario vai ter acesso a aquela informação para usar em outro local
// Quando usamos um método de IndexOf por exemplo, ele nos RETORNA um int, que é a posição do que pesquisamos
//
// Quando o método é chamado, a lista de dados gerada pode ser salva em uma variável.
// Essa variável pode então ser passada para outros métodos ou classes que farão uso dela.
// 
// Exemplo:
// - O primeiro método "ArmazenarDados" lê e salva os dados de um arquivo e **retorna uma lista de objetos Pessoa**.
// - Quem chama esse método (como o método principal no programa) recebe essa lista e armazena em uma variável.
// - Essa variável com a lista de pessoas pode então ser passada para outro método, que a utilizará para
//   realizar operações como processar os dados ou exibir informações.
// 
// Assim, temos um fluxo de dados:
// 1. Um método retorna os dados (neste caso, uma lista).
// 2. Esses dados são armazenados em uma variável.
// 3. Essa variável é passada para outros métodos ou classes que precisam utilizar esses dados.
//
// Agora, vou mostrar um exemplo em código de como isso funciona:
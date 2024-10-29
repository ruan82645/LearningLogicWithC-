
// Vamos entender como funciona o cadastramento de dados dentro de uma tabela(topico)

// No SQL Quando criamos um banco de dados novo, podemos adicionar diversas tabelas, onde cada uma tem seu nicho
// Uma tabela para informações de clientes, outra para produtos, pedidos, lojas...
// Cada tabela tendo seu proprio uso e sendo bem organizada

// Supondo que acabamos de criar uma tabela nova, do total zero, não existe nada nela ainda.
// O primeiro passo é determinar quais tipos de informações terão nessa tabela, dar nome para cada coluna e dizer o que vai lá.
// assim como no excel, que colocamos "Nome" no titulo da coluna e ali colocamos apenas nomes, é quase igual aqui.
// Ao invés de apenas colocarmos o titulo, nós também tipamos o que pode entrar ali e se esse campo pode ser nulo ou não

// Digamos que a primeira coluna será sobre o ID do cliente, então nomeamos como "IdCliente" ou algo assim
// na proxima linha dizemos qual a tipagem de informação que entra ali, nesse caso, é um "int", um numero inteiro.
// depois dizemos se queremos ou não que esse campo possa ser nulo. Nesse caso, de forma nenhuma pode ser nulo.
// ótimo! Cadastramos o id do cliente e podemos marcar que esse campo será uma chave que podemos usar em outras tabelas-
// para conexoes, basta clicar no icone de chave no canto superior direito

// Agora vamos para o nome. Novamente nomeamos o campo, "NomeCliente" Dessa vez.
// depois é a tipagem... Diferente das outras linguagens, texto aqui não é string, é "varchar("número")",
// isso significa que nesse campo pode ser armazenadas strings de tamanho variavel de até X caracteres(você decide o número).
// e novamente o campo de poder ser Null, nesse caso, também não

// Mais um campo, um pouco menos importante que os outros, vamos chama-lo de "IsActive" ou "trabalha".
// Esse campo é uma pergunta, o usuario trabalha? sim ou não? ou seja, é um tipo booleano.
// Nesse caso, o tipo bool é representado por "bit", então colocamos o tipo como bit.
// Como esse campo não é de extrema importancia, podemos deixar com possibilidade de nulo, é um campo não obrigatorio,
// se o usuario do site quiser fornecer essa informação, ele pode, mas se não quiser, tudo bem!

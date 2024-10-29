
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

// o exemplo abaixo mostra exatamente o que pode e não pode ser usado nesse campo após o cadastro

// Vale lembrar que devemos marcar uma opção para que quando adicionarmos algo novo, o id implemente sozinho,
// ou seja, ele sempre vai gerar um numero novo conforme novos usuarios. Além disso, um id nunca será repetido,
// mesmo que apague aquele cliente ou produto, o id que foi usado não poderá ser usado novamente por questão de segurança.

//      Correto     |     Errado
//-----------------------------------
// |   idCliente  |   |  idCliente |
// |   032(pode)  |   | ruan(erro) |
// |   176(pode)  |   | true(erro) |
// |   254(pode)  |   | 2,15(erro) |
// |   347(pode)  |   |     (erro) |



// Agora vamos para o nome. Novamente nomeamos o campo, "NomeCliente" Dessa vez.
// depois é a tipagem... Diferente das outras linguagens, texto aqui não é string, é "varchar("número")",
// isso significa que nesse campo pode ser armazenadas strings de tamanho variavel de até X caracteres(você decide o número).
// nesse caso, vamos dizer que é apenas o primeiro nome, então "varchar(10)", pode conter apenas 10 caracteres no nome
// e novamente o campo de poder ser Null, nesse caso, também não.

//       Correto       |         Errado
//-------------------------------------------
// |   NomeCliente   |   |    NomeCliente    |
// |   Ruan   (pode) |   |     074    (erro) |
// |   Larissa(pode) |   |     true   (erro) |
// |   Leomar (pode) |   | Dhyennipher(erro) |
// |   Eric   (pode) |   |            (erro) |

// Mais um campo agora, um pouco menos importante que os outros, vamos chama-lo de "IsActive" ou "trabalha".
// Esse campo é uma pergunta, o usuario trabalha? sim ou não? ou seja, é um tipo booleano.
// Nesse caso, o tipo bool é representado por "bit", então colocamos o tipo como bit.
// Como esse campo não é de extrema importancia, podemos deixar com possibilidade de nulo, é um campo não obrigatorio,
// se o usuario do site quiser fornecer essa informação, ele pode, mas se não quiser, tudo bem!

//     Correto      |         Errado
//-----------------------------------------
// |   Trabalha   |   |      Trabalha     |
// |   sim (pode) |   |     074    (erro) |
// |   não (pode) |   | email@gmail(erro) |
// |       (pode) |   | Dhyennipher(erro) |


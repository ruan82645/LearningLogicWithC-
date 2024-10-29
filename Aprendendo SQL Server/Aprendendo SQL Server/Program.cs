// Nesse módulo, vamos entender um pouco mais sobre o SQL Server. Para que serve, como usar...

// SQL Server é onde criamos e editamos bancos de dados para serem utilizados em nossa aplicação ou site,
// lá pode conter todas as informações de usuários que acessam seu site, que fazem um pedido, compra.
// Lá registramos tudo o que acontece por trás da tela, é o lugar onde se armazena tudo,
// por exemplo: podemos ter um banco de dados em um site de compra, um "e-commerce". Quando o cliente-
// digita seu usuario e senha, vamos até o banco de dados onde estavam armazenadas essas informações,
// conferimos o usuario e se a senha realmente bate com aquilo e então liberamos o acesso


// Uma coisa importante, um banco de dados no sql server é muito parecido com uma planilha do excel
// Pense em uma planilha de um veterinário, lá tem alguns tipos de dados, como:
// nome do dono, email do dono, endereço do dono, profissão, etc...
// também há nome do pet, idade do pet, doenças anteriores, raça, e etc...
// Agora imagine que esa planilha está organizada da seguinte forma:

// | nomeDono |    email      | endereço |  profissão  | nomePet | idadePet | doençasAnteriores  |   raça    |
//------------------------------------------------------------------------------------------------------------
// | Larissa  | lri@gmail.com | QE 40    | Professora  | Oddie   | 12 anos  | problema de coluna | salsicha  |
// | Larissa  | lri@gmail.com | QE 40    | Professora  | Pipoca  | 04 anos  | trauma de chuva    | vira-lata |

// Perceba que se a mesma pessoa tiver mais de um pet, toda vez irei repetir os dados do dono,
// quando eu quiser adicionar um novo pet, terei que novamente colocar as informações do mesmo dono, etc
// tornando totalmente impratico e de dificil manutenção

// Agora imagine que existam duas páginas(abas) na mesma planilha, uma dessas, teria as informações de donos
// enquanto na outra, somente dos pets
// digamos que colocamos todos os dados de um cliente humano e demos um número único para ele, um "id".
// nesse id vão estar todas as informações do dono, por exemplo:" id 032 | Larissa Ribeiro "
// o id 032 vai ter: nome, email, endereço e profissão.
// Agora quando adicionarmos um pet novo, não precisamos repetir todas as informações do dono
// podemos apenas colocar o id do dono ali, então vamos saber que aquele pet pertence a tal dono

// Dessa forma, o cliente seria cadastrado uma unica vez, sem repetições bobas, vou mostrar em exemplo:

// Cadastro de Donos:
// | DonoId  | nomeDono |    email       | endereço |  profissão  |
//-----------------------------------------------------------------
// |   032   | Larissa  | lri@gmail.com  | QE 40    | Professora  |
// |   057   | Ruan     | ruan@gmail.com | QE 38    | Dev Junior  |
// |   091   | Leomar   | leo@gmail.com  | QE 21    | Bombeiro    |

// temos 3 clientes cadastrados, agora vamos cadastrar os pets, onde cada dono terá 2 pets diferentes

// Cadastro de Pets:
// | DonoId  | nomePet  | idadePet | doençasAnteriores  |   raça    |
// -----------------------------------------------------------
// |   032   | Oddie    | 12 anos  | problema de coluna | salsicha  |
// |   032   | Pipoca   | 04 anos  | trauma de chuva    | vira-lata |
// |   057   | Ravena   | 01 ano   | Nenhum             | salsicha  | 
// |   057   | Sasha    | 05 anos  | Febre              | Golden    |
// |   091   | Jackie   | 03 anos  | pneumonia          | Huskie    |
// |   091   | Romeu    | 07 anos  | Nenhum             | pastor    |

// Note que eu não preciso mais ficar colocando todas as informações do dono, eu apenas ligo os dois pelo id.
// é assim que o banco de dados funciona para diversos tópicos, onde podem haver diversos ids para outras coisas.

// Agora, imagine uma loja de bicicletas, nela nós temos o cliente, o pedido, produtos, lojas fisicas, estoques, etc.
// cada produto(bicicleta) tem um id, possui uma marca(um id diferente), categoria(outro id).
// cada estoque tem um id, cada loja tem ids diferentes que podem ser determinada cidade, tamanho, etc

// para cada coisa, podemos ter varios ids, que nos ajudam a conectar tópicos diferentes de uma forma mais fácil e organizada

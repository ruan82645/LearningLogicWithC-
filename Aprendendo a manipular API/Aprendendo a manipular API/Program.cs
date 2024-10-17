// Vamos falar um pouco sobre APIs hoje, e suas utilidade gerais

// API significa "Application Programming Interface". É um conjunto de regras
// que permite a comunicação entre dois sistemas diferentes. Pense em uma API
// como uma ponte que conecta seu aplicativo a outros serviços, permitindo que
// você use dados ou funções que eles fornecem.

// Muitas grandes empresas e serviços, como Google, Twitter, Facebook e TMDb
// (The Movie Database), oferecem suas próprias APIs. Isso permite que você
// possa acessar dados como informações de filmes, clima, e muito mais.
// Essas empresas compartilham seus dados e funcionalidades com outros
// desenvolvedores por meio de APIs, que funcionam como canais de comunicação.

//Para usar uma API, você precisa seguir as regras e instruções fornecidas
// pela "documentação" da API. Que geralmente é encontrada onde a Api é fornecida pelo criador.
// A documentação ensina como fazer requisições
// (como o garçom que leva seu pedido à cozinha) e quais dados você pode
// acessar ou enviar. Sem a documentação, seria como tentar falar uma língua
// desconhecida sem dicionário.

// APIs costumam enviar e receber dados em formatos padronizados como JSON
// (JavaScript Object Notation). Por exemplo, quando você faz uma requisição
// para uma API que fornece dados sobre usuários, a resposta pode vir assim:

// {
//     "name": "John",
//     "age": 30,
//     "city": "New York"
// }

// Esses dados chegam no formato JSON, mas para o seu programa entender e
// manipular esses dados, é preciso convertê-los. Esse processo é chamado de
// "desserialização". Desserializar significa transformar o JSON em um objeto
// ou estrutura de dados que seu programa pode usar diretamente, como uma
// classe ou variável. É necessário em todas as linguagens, seja em Js, Ts, C#, etc.
// Para C# podemos usar uma biblioteca chamada "Newtonsoft.Json",
// que possui funções para Serializar e Desserializar objetos Json e covnerter em C#

// A "serialização", por outro lado, é o processo inverso. Quando você precisa
// enviar dados para uma API, por exemplo, ao preencher um formulário de
// cadastro, você transforma seus dados em JSON ou outro formato que a API
// aceite. Isso é serializar – você empacota seus dados para enviar corretamente.

// APIs permitem fazer diversas operações. Ao fazer um "GET", você está
// pedindo para a API trazer dados, como o garçom pegando um prato na cozinha.
// Já o "POST" serve para enviar dados novos para a API, como enviar informações
// sobre um novo usuário. Assim, o garçom leva seu pedido até a cozinha,
// e a cozinha (servidor) prepara e confirma seu pedido.

// Além de tudo isso, as APIs seguem protocolos como HTTP, que garantem que
// as requisições e respostas sejam transmitidas de forma organizada e segura.
// Esses protocolos garantem que a comunicação ocorra corretamente, como se
// fossem regras de trânsito para as trocas de informação.
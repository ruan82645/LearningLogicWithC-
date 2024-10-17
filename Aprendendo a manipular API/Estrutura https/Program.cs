// A estrutura de um link de API (ou URL) é composta por várias partes,
// cada uma com sua função específica. Vamos analisar as partes comuns
// de uma URL quando a digitamos no campo de url de um navegador...

// 1. **Protocolo**: A URL geralmente começa com "http://" ou "https://",
// onde "https" é a versão segura do protocolo. Isso significa que os
// dados trocados são criptografados, aumentando a segurança.

// 2. **Host**: Após o protocolo, você verá o domínio do servidor,
// que é o local onde a API está hospedada. Por exemplo, em 
// "https://api.exemplo.com", "api.exemplo.com" é o host.

// 3. **Caminho**: Depois do host, pode haver um caminho que indica
// qual recurso específico você deseja acessar. Por exemplo, em 
// "https://api.exemplo.com/users", "/users" é o caminho que
// indica que você está acessando a lista de usuários.

// 4. **Parâmetros de consulta**: Após o caminho, você pode adicionar
// uma interrogação (?) para iniciar a lista de parâmetros de consulta.
// Esses parâmetros são usados para passar informações adicionais para a
// API, como filtros ou especificações de pesquisa. Por exemplo:
//
// https://api.example.com/users?age=30&city=Brasilia
//
// Aqui, "age=30" e "city=Brasilia" são parâmetros que informam à API
// para filtrar os usuários que têm 30 anos e moram em Brasilia-DF.

// Então o vamos colocar toda a estrutura aqui para melhorar o entendimento:

// https://api.example.com/users?age=30&city=NewYork
//  - Protocolo: https
//  - Host: api.example.com
//  - Caminho: /users
//  - Parâmetros de consulta: age=30&city=NewYork

// Quando você faz uma requisição a uma API usando HTTP, pode usar
// diferentes métodos, como GET (para buscar dados), POST (para enviar
// dados), PUT (para atualizar dados) e DELETE (para remover dados).
// Cada método tem sua própria função e uso específico, ajudando a
// definir a operação que você deseja realizar na API.
// Vmao entender um pouco sobre como o NuGet Rest Sharp funciona

// RestSharp é uma ferramenta que facilita o consumo de APIs, também permitindo
// postar, editar, deletar dados da API

// antes, de explicar melhor como o código funciona, preciso explicar alguns termos antes:

/*Vamos recaptular os termos da Url para não causar confusão ao usar o RestSharp
 
 Primeiro, para melhor adaptabilidade, imagine o caminho de um arquivo no windows,
 Dentro do explorador de arquivos mesmo... Pense naquele caminho completo até um pdf por exemplo

 Nesse caminho, existe: o Disco, as pastas e subpastas até chegar no arquivo

 Da mesma forma funciona a Url, que contem o site em si, o caminho até algo e parametro

 Imagine que você quer acessar uma API de um site para ver conteudos relacionados aos usuários,
 para isso, na Url, nós colocamos o site(o disco), os caminhos separados por "/" até chegar lá

 "https://SiteExemplo.com.br/Contas/Users?Age=30&Gender=Woman"

 Aqui, nessa url de API nós queremos pegar as informações de usuárias mulheres de 30 anos,
 mas como isso é feito? primeiro, dizemos de onde queremos puxar a informação, ou seja,
 do "SiteExemplo", nossa BaseUrl também chamada de "Client", também é nosso "disco C:".

 O client em RestSharp é representado pelo tipo "RestClient", é uma classe instanciavel
 que recebe o valor da BaseUrl, e que também pode carregar Headers(cabeçalhos/autorização)
 (vamos ver sobre os Headers depois)

 Agora que entramos no "disco", precisamos ir acessando de pasta em pasta, até chegar no resultado,
 Então passamos primeiro pelas informações de contas, e depois entramos na parte de usuarios,
 essas são as nossas pastas e subpastas, cada uma contem informações diferentes,
 mas vamos entrando mais e mais até chegar onde nosso "arquivo" realmente está.
 Isso é o que chamamos de "EndPoint", é o caminho até de onde você vai tirar as informações,
 

 

 


    
 */




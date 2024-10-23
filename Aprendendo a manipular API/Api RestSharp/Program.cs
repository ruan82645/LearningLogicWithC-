using RestSharp;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

// Vamos entender um pouco sobre como o NuGet Rest Sharp funciona

// RestSharp é uma ferramenta que facilita o consumo de APIs, também permitindo
// postar, editar, deletar dados da API

// antes, de explicar melhor como o código funciona, preciso explicar alguns termos antes:

//Vamos recaptular os termos da Url para não causar confusão ao usar o RestSharp

//Primeiro, para melhor adaptabilidade, imagine o caminho de um arquivo no windows,
//Dentro do explorador de arquivos mesmo... Pense naquele caminho completo até um pdf por exemplo

//Nesse caminho, existe: o Disco, as pastas e subpastas até chegar no arquivo

//Da mesma forma funciona a Url, que contem o site em si, o caminho até algo e parametro

//Imagine que você quer acessar uma API de um site para ver conteudos relacionados aos usuários,
//para isso, na Url, nós colocamos o site(o disco), os caminhos separados por "/" até chegar lá

//Imagine que você quer acessar uma API de um site para ver conteudos relacionados aos usuários,
//para isso, na Url, nós colocamos o site(o disco), os caminhos separados por "/" até chegar lá

// ------------------------------------------------------------------------------------------------

// |---   |      |   |---   |\  |  --|--
// |      |      |   |---   | \ |    |    
// |___   |___   |   |___   |  \|    |    

//"https://SiteExemplo.com.br/Contas/Users?Age=30&Gender=Woman"

//Aqui, nessa url de API nós queremos pegar as informações de usuárias mulheres de 30 anos,
//mas como isso é feito? primeiro, dizemos de onde queremos puxar a informação, ou seja,
//do "SiteExemplo", nossa BaseUrl também chamada de "Client", também é nosso "disco C:".

//O client em RestSharp é representado pelo tipo "RestClient", é uma classe instanciavel
//que recebe o valor da BaseUrl, e que também pode carregar Headers(cabeçalhos/autorização)
//(vamos ver sobre os Headers depois)

RestClient client = new RestClient("https://SiteExemplo.com.br");

// ------------------------------------------------------------------------------------------------

// |--.  |---  |---|  |   |  |---  ___  --|--
// |--°  |---  |  \|  |   |  |---  |__    |
// |\    |___  |__ \  |---|  |___  ___|   |

//"https://SiteExemplo.com.br/Contas/Users?Age=30&Gender=Woman"

//Agora que entramos no "disco", precisamos ir acessando de pasta em pasta, até chegar no resultado,
//Então passamos primeiro pelas informações de contas, e depois entramos na parte de usuarios,
//essas são as nossas pastas e subpastas, cada uma contem informações diferentes,
//mas vamos entrando mais e mais até chegar onde nosso "arquivo" realmente está.
//Isso é o que chamamos de "EndPoint", é o caminho até de onde você vai tirar as informações,

//Os EndPoints são passados em um método também instanciado chamado RestRequest,
//ele pode receber alguns parametros como os Endpoints, o metodo que vamos utilizar(Get, post, etc)
//e até mesmo codificaões quando postamos algo na Api(vamos deixar isso para depois).

//Ou seja, quando criamos uma variavel de Request, essa variavel deve ter quais dados queremos acessar
//e o método que será utilizado para tratar com aquela API

RestRequest request = new RestRequest("/Contas/Users", Method.Get);

//Agora, a variavel request sabe o que deve pedir para a Api quando for chamada

// ------------------------------------------------------------------------------------------------

// |--.  |---|  |--.  |---|  |\    /|  |---  --|--  |---  |--.  ___
// |--°  |---|  |--°  |---|  | \  / |  |---    |    |---  |--°  |__ 
// |     |   |  |\    |   |  |  \/  |  |___    |    |___  |\    ___|

//"https://SiteExemplo.com.br/Contas/Users?Age=30&Gender=Woman"

// Então chegamos na parte parametros, imagine que voce já chegou na sua pasta
// lá dentro vai ter varios arquivos, e para isso servem os parametros, filtrar o que vai vir
// de dentro dessa "pasta"

// os parametros são passados após a interrogação na url, e cada parametro é dividido em:
// chave e valor, por exemplo "Age=30", caso eu queira mais parametros, posso acrescentar um "&"
// e logo em seguida usar um novo

// Parametros são passados na requisição, e isso faz sentido, pensa comigo...
// Requisição é a ação de buscar ou colocar algo onde voce deseja, já cliente é so o site.
// Certo... Mas como passamos os paramêtros para a Requisição então? 

// elas podem ser passadas chamando a variavel da requisição e usando Add parameter.
// Isso é um método que recebe dois valores, que são chave e valor, assim como mencionei antes.
// Ou seja, vamos passar o nome da chave e depois o valor dessa chave,
// Essa ação de acrescentar parametros pode ser feita repetidamente chamando de novo o metodo

request.AddParameter("Age", "30");
request.AddParameter("Gender", "Woman");

// Agora, a variável request carrega todos os parametros dentro de si

// ------------------------------------------------------------------------------------------------

// |   |  |---  |---|  |--. |---  |--.  ___
// |---|  |---  |---|  |  | |---  |--°  |__ 
// |   |  |___  |   |  |__° |___  |\    ___|

// Os Headers, também conhecidos como cabeçalhos são autorizações que você deve passar a api.
// Algumas Apis tem em suas documentações que uma chave de acesso é obrigatória,
// Essa chave é passada pelo provedor da Api para o seu usuario, que te dá direito a usar a Api
// Caso a Header não seja informada, o acesso será bloqueado, mesmo com todos os requests certos

// Vale lembrar que não são todas as Apis que exigem headers, muitas mais simples não usam
// Então basta fazer executar o request sem isso e tudo certo

// As Headers são permissões que te dão acesso ao proprio site, e não necessariamente ao request
// Elas permitem que voce entre no site base, ou seja... na Base Url
// As autorizações podem vir de várias maneiras, e quem determina isso é a documentação
// lá estará qual a chave deve ser usada e qual o valor da chave(sua autorização)

// E como eu disse antes, as Headers são passadas para o Client, para que seja possivel-
// a entrada no site. E como podemos fazer isso? Da mesma forma que colocamos parametros em request.
// chamamos a variavel cliente e usamos o metodo Add.DefaultHeader.
// Novamente, esse tipo de metodo recebe dois parametros, nome da chave e seu valor.
// Caso a documentação peça 1 ou mais autorizações diferentes, passamos mais autorizações diferentes.

client.AddDefaultHeader("authorization", "123456789");
client.AddDefaultHeader("AcessKey", "82645");

// ------------------------------------------------------------------------------------------------

// Então finalmente tratamos dos 4 pontos de que se constituem uma Url, o que vai facilitar-
// de agora em diante

//"https://SiteExemplo.com.br/Contas/Users?Age=30&Gender=Woman"
// |__________________________||___________||_________________|
//       Client = BaseUrl         EndPoint      Parameters

// ------------------------------------------------------------------------------------------------

// |--. |---  ___  |--. |---| |\  | ___  |--- 
// |--° |---  |__  |--° |   | | \ | |__  |---
// |\   |___  ___| |    |___| |  \| ___| |___


// Quando executamos a ação de request em um cliente especifico, ou seja,
// quando requisitamos dados especificos de um site especifico, recebemos uma resposta em troca
// Essa resposta é o resultado do Request, e pode vir em formado Json, Xml, etc...
// O formato que virá a resposta sempre estará na documentação, e basta tratar depois

// Ok, mas como usar a response em código? 

// Response é denominado pelo tipo RestResponse, no mesmo padrão dos outros
// Ela é apenas um tipo, não necessitando de instanciar ou qualquer coisa do tipo

// Ao criar uma variável que recebe dados de um lugar, ela precisa receber um valor dentro de si,
// é por isso que nesse momento realmente fazemos a requisição

// Anteriormente, preenchemos o RestClient e o RestRequest.
// Eles estão lá apenas para passar que dados serão usados em suas determinadas variaveis
// (client é essa url e essa chave, a variavel request pede isso com esse metodo)
// Essas variáveis ainda não fazem nada sozinhas, pois elas armazenam como algo ainda será feito

// Quando declaramos a variavel response, devemos garantir que ela receba o valor da Api
// para isso precisamos realmente executar essas variaveis e botá-las para funcionar
// Para isso chamamos a variavel client para dizer(a ação será nesse site), em seguida-
// usamos o método Execute, que recebe como paramêtro a variavel request,
// e seu nome é auto-explicativo, (execute essa requisição)

// então ao todo ficaria algo como: "nessa url base, execute essa requisição)

RestResponse response = client.Execute(request);

// isso faz uma requisição síncrona, solicitando os dados para a Api e passando para response
// Quando falo síncrona, quero dizer que ele primeiro recebe os dados da Api,
// Somente após isso ele faz outra função, então caso seja uma requisição demorada, pode ficar ruim
// se for algo rápido, realmente não há problema, mas vou mostrar como fazer uma ASSÍNCRONA

// quando fazemos uma requisição assincrona, sempre devemos usar o "Await",
// que a primeira vista parece que ele espera o request ser finalizado para prosseguir, mas...
// é como se significasse ("continue executando as outras coisas enquanto EU espero isso").
// Além do Await na requisição, também devemos dizer o tipo de execução do request,
// ao invés de ser "Execute Request", deve ser "ExecuteAsync(Request)"
// (continue fazendo as outras coisas enquanto eu aguardo essa requisição assíncrona)

RestResponse respostaAsync = await client.ExecuteAsync(request);

// Await é muito importante e não é usado somente no request quando é algo assincrono,
// ele também pode ser usado em outro caso...

// imagine que você fez uma requisição assíncrona e logo abaixo, voce imprime o resultado,
// ou até mesmo no final do codigo... Se isso acontecer, essa função básica de imprimir,
// ou também outras funções irão esperar o resultado da requisição para utilizarem ela.
// Resumindo, se estiverem no mesmo escopo({}) quem usa aquela resposta, irá aguardar.

// Porém se tentar usar a resposta da requisição em um escopo diferente,
// será necessário pedir para a função esperar a resposta da requisição usando o await,
// Quando colocarmos a resposta na função, antes dela devemos colocar o await.
// é quase como iniciar uma variavel em um escopo "filho" e tentar usar no escopo "pai".
// Ele não será reconhecido e vai gerar erro

// O mesmo vale para quando criamos um método que faz o request da Api,
// ele precisa retornar algo assíncrono para quem o chamou,
// então não posso retornar um valor sem pedir para quem chamou esperar.
// Quando deixamos de fazer isso, nós não retornamos o valor que foi trazido da requisição,
// mas sim trazemos a propria requisição.
// Então quando quiser um resultado de uma requisição por metodo, lembre-se:
// use await antes do retorno do metodo

Api api1 = new Api();

int idadeUsuario = await api1.respostaApi("ruan");

// Esse metodo retorna uma resposta de Api, lá dentro tem sim um await, porém...
// Por idadeUsuario e respostaApi estarem em escopos diferentes, preciso usar Await também.

// Vale lembrar que quando criamos um método que retorna algo assíncrono, sua nomenclatura muda,
// Ao invés de ser ("Public String Método()"), deve ser: ("Public async Task<String> Método()"),
// pois ele é uma tarefa que espera pelo resultado ao invés de processar de uma vez.
// Então se estiver usando uma função assíncrona, essa é a sintaxe para se usar um método desse tipo,
// Primeiro colocamos o nivel de acesso, em seguida async Task<Tipo que vai retornar>
// e o nome do método.



//A api abaixo serve para "advinhar sua idade com base no seu nome, apenas isso.
// ele não possui endpoint, apenas parametro

Api api = new Api();

int idade = await api.respostaApi("ruan");

Console.WriteLine(idade);

public class Api
{
    public class Idade
    {
        public int Age { get; set; }
    }

    public async Task<int> respostaApi(string nome)
    {
        RestClient agify = new RestClient("https://api.agify.io");
        RestRequest request = new RestRequest("", Method.Get);
        request.AddParameter("name", nome);

        RestResponse response = await agify.ExecuteAsync<Idade>(request);
        
        Idade idade = JsonConvert.DeserializeObject<Idade>(response.Content);

        return idade.Age;

    }
}


















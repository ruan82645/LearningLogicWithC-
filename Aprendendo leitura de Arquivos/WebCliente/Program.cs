//// Quando precisamos fazer download de algo da internet, seja um arquivo, html de um site ou os bytes de um site,
//// Nós usamos a classe WebClient. Ela é uma classe instanciada,
//// ou seja, precisa ser iniciada com o new após a declaração da variavel e então chamar o método
//// na maioria das classes instanciadas, como DateTime ou DirectoryInfo,
//// a variável que armazena o valor de um método, tem o mesmo tipo da classe

//using System.Net;

//System.IO.DirectoryInfo variavelDiretorio = new System.IO.DirectoryInfo("exemplo");

//// Porém, essa classe WebClient, retorna tipos diferentes dependendo do método usado
//// se quisermos baixar o html de um site para analisar por exemplo, passamos isso para um tipo string,
//// e não para um tipo WebClient

//   string htmlDoSite = new System.Net.WebClient().DownloadString("https://www.gov.br/");
//// aqui, todo o html da página principal do site Gov.br foi baixado e está dentro de "htmlDoSite"

//// Então quando fizer o download de algo, preste atenção para que tipo o método usado retorna o valor

//// WebClient diferente dos outras classes de manipulação de arquivo, System.Net antes de ser chamado
//// pois suas funções são relacionadas a internet, e não entrada e saida de dados do computador

//// Os métodos de WebClient recebem sempre um link da internet, seja do site, ou o link de download de algo.
//// Quando precisamos de informações do site em si, precisamos apenas do link do site, mas ao fazer download de arquivo,
//// usamos o link de download, que é o link do botão onde normalmente clicamos para baixar algo

//// Os métodos mais comuns de WebClient são download de arquivo, download de html e download dos bytes do site
//// pra que fazer download html do site? Vasculhar por coisas escritas que podemos usar de referencia para outras funções.
//// Digamos que tenham x links de download em um site, e para não precisar olhar um por um, fazemos um programa que acha eles,
//// e após encontrar, ele baixa esses arquivos.
//// E os bytes? cada caractere, ou pedaço de um arquivo, é formado por um conjunto de numeros binarios,
//// se conseguirmos baixar os bytes, de um arquivo para converte-lo novamente no seu arquivo original

//// vamos ver um exemplo de como chamar um por um

////----------------------------------------------------------------------------------------------------
//// Download de arquivo
//// DownloadFile()
//// seu primeiro parâmetro, é o link de download, e o segundo, o nome que vai receber ao ser baixado

//// perceba que como ele apenas baixa direto no computador, não precisa salvar valor nenhum em uma variavel
//// então não precisa iniciar nenhuma, apenas usar o comando de download

//    new System.Net.WebClient().DownloadFile("https://www.win-rar.com/predownload.html?&L=9", "win-rar.exe");
//    // aqui, ao executar o programa, ele baixa o winrar automaticamente e salva como "win-rar.exe"

////----------------------------------------------------------------------------------------------------
//// Download do html
//// DownloadString()
//// Seu parâmetro obrigatório é o link do site ou página do site que você quer baixar

//// Nesse, ele não baixa um arquivo html, mas ele armazena todo o texto html do site em uma string
//// então é necessário salvar o valor de DownloadFile dentro de um tipo string para ser usado depois

//   string html = new System.Net.WebClient().DownloadString("https://www.gov.br/");
//// salvou na string html o texto html do site do gov

////----------------------------------------------------------------------------------------------------
//// Download dos bytes
//// DowloadData()
//// Seu parâmetro obrigatório é o link de download de um arquivo

//// Aqui, ele não baixa o arquivo normalmente, ele vai desconstruir o arquivo em varios bytes e salvar em um array,
//// Ou seja, devemos criar um array de bytes para armazenar todos eles

//   byte[] ArrayDeBites = new System.Net.WebClient().DownloadData("https://www.win-rar.com/predownload.html?&L=9");
////----------------------------------------------------------------------------------------------------


////Sem enrolação, vamos para os exercicios 

////1) solicitar a url de um site, vasculhar o html dele e baixar todos os arquivos .exe que tem por lá

Console.WriteLine("por favor, insira o link de um site que contenha downloads");
string site = Console.ReadLine();

string htmlSite = new System.Net.WebClient().DownloadString("https://git-scm.com/downloads/win");

int http = 0;
int exe = 0;

if (htmlSite.Contains("https://") && htmlSite.Contains(".exe"))
{
    while (htmlSite.IndexOf(".exe") != -1)
    {
        exe = htmlSite.IndexOf(".exe", exe);
        http = htmlSite.LastIndexOf("https://", exe);

        int numeroDeCaracteres = (exe + 4) - http;

        string linkDownload = htmlSite.Substring(http, numeroDeCaracteres);

        string nomeArquivo = Path.GetFileName(linkDownload);

        if(linkDownload.StartsWith("http") && linkDownload.EndsWith("exe"))
        {
            new System.Net.WebClient().DownloadFile(linkDownload, nomeArquivo);

            Console.WriteLine($"fazendo download do arquivo {nomeArquivo}");
        }

        http++;
        exe++;
    }
}

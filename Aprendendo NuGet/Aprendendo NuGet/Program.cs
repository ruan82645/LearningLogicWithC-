
// Para mexer com documentos Excel, tanto criar, quanto escrever, etc. 
// Podemos usar o EPPlus do Nuget, que contem algumas funções exclusivas para isso

// Sua princpal classe que vai permitir a maior parte das alterações é o "ExcelPackage",
// que é uma classe não estática(instanciavel), ou seja, necessita ser iniciada e ter seu valor passado para uma variavel
// Excel Package recebe um valor principal, sendo um arquivo já existente para trabalhar em cima, ou uma MemoryStream,
// que serve para ir criando o excel na memoria Ram e somente após terminar, nós o criamos como arquivo.

// primeiramente, vou explicar um pouco sobre a MemoryStream.
// Como dito antes, ela permite criar algo na memoria Ram, construindo byte por byte,
// ao final da edição do "arquivo", nós podemos dar um fim a ele, desde criar realmente um arquivo no computador, ou
// importar esses dados em bytes para outro local, e lá esses dados serão analisados e reconstituidos em um arquivo de verdade.
// Quando criamos uma variavel "MemoryStream", é como se criassemos uma "caixa" temporaria na memoria ram,
// e dentro dessa caixa, nós colocamos tudo o que queremos usar para contruir algo. Quando terminamos, salvamos essa caixa,
// e então damos um uso para ela.

// Agora sim, irei explicar sobre ExcelPackage.
// ExcelPackage pode receber tanto o caminho de um arquivo existente, quanto a variavel MemoryStream(criação na ram).
// Ela é uma classe que permite a criação de uma variavel que contem informações necessárias para criação e edição de planilhas.
// essa variavel possui diversas propriedades e métodos, algumas propriedade são:
// 1 - workbook(pense nele como se fosse todo o arquivo do excel... o como se fosse o "arquivo" inteiro)
// 2 - worksheets(são as abas do excel, as varias planilhas que criamos dentro de um arquivo)
// 3 - cells(as celulas e seus conteudos internos)
// Cada propriedade aprofunda mais sobre algo, e cada propriedade possui seus proprios métodos caso queira usar

// para entendermos um pouco da ligação entre o MemoryStream e o ExcelPackage, pense no stream como uma caixa,
// pense nesse exemplo: "var caixaExcel = ExcelPackage("caixaStream")"
// definimos que dentro de caixaExcel, só serão guardadas informações sobre Excel, e quando queremos guardar algo, chamamos ela.
// Ao final, quando acabamos e já colocamos tudo que queriamos na caixa, salvamos ela e pedimos para "outra pessoa" montar.

// uma coisa MUITO importante para quando criamos um excel do zero e queremos salvar em arquivo...
// Quando estamos "guardando as coisas na caixa", é como se estivessemos escrevendo com uma caneta,
// conforme vamos escrevendo, a caneta vai indo para frente e assim vai até chegar no final e acabar de escrever,
// mas para ler o que escrevemos, precisamos voltar a caneta no inicio e ir passando letra por letra para ajudar na leitura, certo?
// Aqui é a mesma coisa, enquanto criamos o excel, a posição da variavel MemoryStream vai indo para frente, byte por byte,
// e quando terminamos de criar, a posição dela está nos ultimos bytes.
// Só que quando criamos um arquivo, usamos File.ReadAllBytes() que lê os bytes da posição Stream em frente,
// após isso ele cria o arquivo, mas ele não pode ler nada se a posição Stream estiver nos ultimos bytes.
// Para resolver isso, nós fazemos "variavelStream.Position = 0"
// Assim nós resetamos a posição e após isso pedimos para criar o arquivo




// Quando queremos criar uma aba, depois de .workbook, usamos o .WorkSheet.add("nome da aba"),
// armazenamos esse valor em uma variavel e cada variavel desse tipo, será uma nova aba de uma arquivo excel

//ExcelWorksheet aba1 = package.Workbook.Worksheets.Add("minha planilha");


// E para editar as células? como faço para dizer qual eu quero mexer e o que eu quero escrecer?
// podemos acessar .cells[] pela variavel da aba que criamos
// .cells[] diz em qual célula nós vamos escrever, dentro dela podemos colocar ["B1"], ["A3"], ["Z7"], ["Y14"] por exemplo.
// E para escrever, nós usamos .value = "". 


using OfficeOpenXml;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // If you use EPPlus in a noncommercial context
            // according to the Polyform Noncommercial license:
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var stream = new MemoryStream();
            var package = new ExcelPackage(stream);

            ExcelWorksheet aba1 = package.Workbook.Worksheets.Add("minha planilha");
            aba1.Cells["A1"].Value = "1";

            stream.Position = 0;
            File.WriteAllBytes("excel.xlsx", stream.ToArray());

        }
    }
}

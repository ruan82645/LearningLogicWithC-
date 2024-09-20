//Vamos então ao Split, como ele funciona? 
//Split funciona dividindo uma string e armazenando em um array
//lembre-se, todos esses metodos alteram uma string e passam o valor para outra
//nesse caso em especifico, é em um array, mas nna maioria é uma string normal
//então os outros metodos tem que armazenar o valor em outra string
//Como assim?
//vou te mostrar uns exemplos:

//string exemplo1 = "minha lista de compras";

//Se escolhermos usar " "(espaço) para dividir essa frase, o Split vai pegar cada palavra
//e então colocar ela dentro de um array
//ele funciona criando um array novo e passando o valor da string criada + .Split()
//dentro do Split, colocamos o que desejamos usar para dividir:

//string[] ArrayExemplo = exemplo1.Split(" ");

//Usei espaço para dividir, então tudo que tiver antes e depois de um espaço, será armazendo
//Lembrando que oq for usado para dividir, irá sumir, só ficara o que vem antes e depois
//e como um Array normal, cada parte dividida, terá um valor index
//mais ou menos assim:

//  ArrayExemplo = ["minha", "lista", "de", "compras"];

//Mas só posso usar espaço? Não, qualquer caractere pode ser usado, inclusive passado pelo usuario
//Quer ver?

//string Exemplo2 = "Um dia vou voar de avião";
//string divisor = Console.ReadLine();

//string[] ArrayExemplo2 = Exemplo2.Split(/*divisor*/"a");// vamos supor que ele escolheu "a"

//ficaria assim o array: ArrayExemplo2 = ["Um di, " vou vo", "r de ", "vi", "o"]

//Assim podemos usar ele de algumas formas... Tem uns exercicios abaixo caso queira ver exemplos



//Esse é bem simples, você digita algo, e será escrito cada palavra de linha em linha: "ruan"
//                                                                                     "pablo"
//                                                                                     "alves"
//Console.WriteLine("Digite uma frase para quebrar");
//string frase = Console.ReadLine();

//string[] quebrado = frase.Split(" ");

//for (int i = 0; i < quebrado.Length; i++)
//{
//    Console.WriteLine($"palavra {i + 1}: {quebrado[i]}");
//}


//Nesse, a pessoa escolhe qual o divisor, e então exibe item por item: "item 1: maçã
//                                                                     "item 2: banana
//                                                                     "item 3: abobora
//Console.WriteLine("digite sua lista de compras");
//string lista = Console.ReadLine();
//Console.WriteLine("digite por qual Char vc quer dividir essa lista");
//string quebra = Console.ReadLine();

//string[] listaCompras = lista.Split(quebra);

//for (int i = 0; i < listaCompras.Length; i++)
//{
//    Console.WriteLine($"item {i + 1}: {listaCompras[i]}");
//}


//Nesse, usamos o ".Length" do array do Split para dizer quantos arrays tem lá dentro
//
//
//Console.WriteLine("digite uma frase para serem contatadas as palavras");
//string frase2 = Console.ReadLine();

//string[] palavras = frase2.Split(" ");

//Console.WriteLine();
//Console.WriteLine("Total de palavras: " + palavras.Length);


//Nesse, eu usei Join() depois de resolver "Gabriel que me pediu kkkK"
//Deveria separar uma frase, e então juntar novamente com outro caracter unindo eles
//Da primeira vez, eu fiz um loop que usava "Console.Write" para escrever item por item, um na frente do outro

//Console.WriteLine("digite palavras para quebrar");
//string palavras2 = Console.ReadLine();
//Console.WriteLine();

//Console.WriteLine("digite um caractere de quebra");
//string quebra2 = Console.ReadLine();
//Console.WriteLine();

//Console.WriteLine("agora digite um caractere para poder unir eles");
//string uniao = Console.ReadLine();
//Console.WriteLine();

//string[] quebrado2 = palavras2.Split(quebra2);

//Console.WriteLine("frase original: " + palavras);
//Console.WriteLine();

//string unida = string.Join(uniao, quebrado2);
//Console.WriteLine($"frase unida: {unida}");

//Console.WriteLine();

//Console.ReadKey();


//Aqui dividiamos as palavras e depois diziamos qual queriamos encontrar
//o programa passa item por item, até encontrar
//quando faz isso, ele mostra todos os itens até exibir o item procurado e só depois ele para
//da uma olhada no "if e else" pra entender melhor
//Console.WriteLine("digite palavras aléatorias");
//string palavras3 = Console.ReadLine();
//Console.WriteLine();

//Console.WriteLine("digite um caractere de quebra");
//string quebra3 = Console.ReadLine();
//Console.WriteLine();

//Console.WriteLine("qual das palavras que digitou, você quer encontrar?");
//string search = Console.ReadLine();
//Console.WriteLine();

//string[] quebrado3 = palavras3.Split(quebra3);

//for (int i = 0; i < quebrado3.Length; i++)
//{
//    if (!(quebrado3[i] == search))
//    {
//        Console.WriteLine($"parte{i + 1}: {quebrado3[i]}");
//    }
//    else
//    {
//        Console.WriteLine($"parte{i + 1}: {quebrado3[i]}");
//        break;
//    }

//}

//Esse não foi um dos mais fáceis, mas não foi tão dificil quanto o 2°
//aqui o usuario informa uma palavra e devemos inverter ela
//primeiro usamos o split para fazer um array com as palavras
//geramos um int index com o valor do Length do array
//e agora para cada iteração, ele imprime o valor do index - 1

//Console.WriteLine("informe um texto para ser invertido");
//string texto5 = Console.ReadLine();

//string[] quebraTexto5 = texto5.Split(" ");
//int index5 = quebraTexto5.Length;

//foreach (string s in quebraTexto5)
//{
//    Console.Write(quebraTexto5[index5 - 1] + " ");
//    index5 = index5 - 1;
//}

//aqui o usuario informa uma palavra e devemos inverter ela
//primeiro usamos o split para fazer um array com as palavras
//geramos um int index com o valor do Length do array
//e agora para cada iteração, ele imprime o valor do index - 1

//Console.WriteLine("informe um texto para ser invertido");
//string texto = Console.ReadLine();

//string[] quebraTexto = texto.Split(" ");
//int index = quebraTexto.Length;

//foreach(string s in quebraTexto)
//{
//    Console.Write(quebraTexto[index-1]+" ");
//    index = index - 1; 
//}


//Esse aqui eu demorei, mas não é tão dificil
//bati demais a cabeça em usar o foreach no lugar do for
//isso fazia que ele sempre bugasse, ai mudei para o for e foi mais fácil
//isso serve para imprimir varios nomes. Um maiusculo, um minusculo...
//e assim por diante

//Console.WriteLine("digite alguns nomes por favor, sem espaço e divididos por \";\"");
//string nomes = Console.ReadLine();

//string[] arrayNomes = nomes.Split(";");

//int i = 0;
//string nomeMaior = "";

//for (i = 0; i < arrayNomes.Length; i = i + 2)
//{

//    nomeMaior = arrayNomes[i].ToUpper();



//    if (i == 0)
//    {
//        Console.WriteLine(nomeMaior);
//    }
//    else
//    {

//        Console.WriteLine(arrayNomes[i - 1].ToLower());
//        Console.WriteLine(nomeMaior);

//    }



//}

//Esse, a pessoa digita uma frase
//então o que quer que seja removido dela
//depois o que quer colocar no lugar da palavra removida
//então o codigo vai escrevendo palavra por palavra até encontrar a escolhida
//ele escreve a palavra que o usuario pediu no lugar daquela
//e então caso o contador não seja maior que o length da frase
//ele coloca um espaço

//Console.WriteLine("digite uma frase");
//string fraseParaSubstituir = Console.ReadLine();
//Console.WriteLine("digite o que quer substituir disso");
//string CoisaParaSubstituir = Console.ReadLine();
//Console.WriteLine("digite o que deve colocar naquele lugar");
//string incluir = Console.ReadLine();

//string[] arrayDePalavras = fraseParaSubstituir.Split(" ");

//int i = 0;

//foreach (string palavra in arrayDePalavras)
//{
//    if (palavra == CoisaParaSubstituir)
//    {
//        Console.Write(incluir);
//    }

//    if (palavra != CoisaParaSubstituir)
//    {
//        Console.Write(palavra);

//    }

//    if (i < arrayDePalavras.Length)
//    {
//        Console.Write(" ");
//    }
//    i++;
//}


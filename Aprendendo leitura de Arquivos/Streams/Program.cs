// Stream
// O conceito da palavra Stream é meio complexo, mas vamos focar em sua utilidade para saber quando usar.
// Streams são classes não estáticas, que devem ser iniciadas com uma variavel Stream, assim como DateTime.
// Elas permitem que você leia ou escreva dados em partes de forma sequencial usando StreamReader ou StreamWriter
// o que é útil quando o arquivo é muito grande ou quando queremos manipular pequenos pedaços por vez.
// Ao invés de ler um arquivo inteiro, podemos ler linha por linha por exemplo
// quando escrever em um arquivo, podemos escrever linha por linha
// Quando precisar editar algo DENTRO do arquivo, que necessite ser feito ponto a ponto, use o Stream

System.IO.StreamReader leitor = new System.IO.StreamReader("texto.txt");
// com o leitor, podemos ler linha por linha do texto dentro do arquivo.
// esse exeplo é apenas para mostrar como iniciar a variavel,
// está explicado como usar e como funciona esse leitor na aba StreamReader dedicada a ele

System.IO.StreamWriter escritor = new System.IO.StreamWriter("texto.txt");
// com o escritor, podemos escrever linha por linha dentro do texto do arquivo
// esse exeplo é apenas para mostrar como iniciar a variavel,
// está explicado como usar e como funciona esse leitor na aba StreamReader dedicada a ele


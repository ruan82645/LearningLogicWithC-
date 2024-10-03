
// File: é uma classe estática que opera exclusivamente em arquivos individuais de uma única vez.
// Como assim? File executa sua ação no arquivo desejado, sem a possibilidade de mexer em apenas uma parte do arquivo.
// se quisermos ler um arquivo, ele será lido inteiro
// se quisermos mover ou copiar um arquivo para outro local, ele será inteiro afetado
// File permite: ler, mover, copiar, deletar arquivos e outras funções.
// Quando precisar mexer em um arquivo por completo, use File
// Em geral, File lida com o arquivo como um todo,
// mas quando queremos manipular partes específicas, Stream é a melhor opção.

string textoInteiro = System.IO.File.ReadAllText("texto.txt");
//textoInteiro armazena todo o texto do arquivo texto.txt

// Lembre que File sempre irá mexer com o arquivo por inteiro, e não com partes de seu interior

// Agora que está melhor explicado sobre ele como um todo, pode ir para o detalhamento de cada função e como usar 
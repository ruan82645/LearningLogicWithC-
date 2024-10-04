// Criação e destruição de pastas com Directory.CreateDirectoy e Directory.Delete
// Com o Diretory, (não com Diretory.Info), podemos tanto criar novas pastas, quanto deletar pastas
// Seu funcionamento é simples de entender e bem auto explicativo.
// como estamos criando ou destruindo algo, não precisamos armazenar nenhum valor a nada, apenas executar o comando
// para exercutar, devemos chamar o Directory.Create ou Delete, passar o caminho e o nome da pasta.

// com o Create, passamos o caminho e no final, na ultima parte do caminho, colocamos o nome da pasta que queremos
// uma pasta com o mesmo nome não será criada novamente, sem dar erro, ela apenas não será criada

   System.IO.Directory.CreateDirectory("C:\\users\\ruanp\\pasta_Exemplo");
   // veja que a ultima parte se refere ao nome do diretorio que foi criado. Ele é obrigatório!


// com o Delete, devemos tomar muito cuidado, pois ele apaga a pasta e tudo que estiver dentro dela
// usamos o mesmo principio dos outros. Damos o caminho do diretório, então ele será excluído.

    System.IO.Directory.Delete("C:\\users\\ruanp\\pasta_Exemplo");
    // caso o diretório informado não exista, o código dará erro

// Creio que não há mais o que explicar sobre isso, é bem transquilo e simples de entender

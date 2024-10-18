
// Normalmente para consumir uma Api, nós precisamos passar uma série de parâmetros e usar uma biblioteca.
// No exemplo desse programa não... Pois ele é uma Api extremamente simples, que não necessita dessas coisas,
// O "viacep.com.br" é um site, ou melhor... um serviço que quando digitamos um cep na sua url, por exemplo:
// "viacep.com.br/ws/71070522/json/", ele retorna escrito no site em texto comum e mais nada os dados do endereço daquele Cep
// foi de lá que tiramos os outros exemplos de Serialização e Desserialização. Ele converte um cep, em um Json escrito em tela.

// Como eu disse, ele faz apenas isso e esse é o unico tipo de informação que ele trás,
// então não precisamos de algo complexo ou pensar muito para usar. Para consumir essa "Api", basta colocar nosso cep em sua URL,
// baixar o html do site, pois ele só mostra em tela a informação que pedimos e absolutamente mais nada(tudo em branco),
// e depois, desserializar isso

// vamos criar uma classe que armazena os dados e outra que usa esses dados ok? E então Chamar no programa principal

using consumindo_uma_api_sumples;

Console.WriteLine("digite o cep que deseja consultar");
string cep = Console.ReadLine();

Leitura servico = new Leitura();

Endereco endereco = servico.ConsultaCep(cep);

imprecao.exibirDados(endereco);



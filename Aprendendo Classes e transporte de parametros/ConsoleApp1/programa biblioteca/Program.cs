using programa_biblioteca;

biblioteca biblioteca = new biblioteca();

int i = 0;
Console.WriteLine("Adicione livros");
// Adicionar livros
while (i < 6)
{
        biblioteca.AdicionarLivro();
    i++;
}

// Adicionar 2 clientes
i = 0;
Console.WriteLine("Vamos adicionar 2 clientes.");
while (i < 2)
{
    biblioteca.AdicionarCliente();
    i++;
}

// Loop para gerenciar empréstimos de livros
while (true)
{
    Console.WriteLine("Deseja emprestar um livro? (s/n)");
    string resposta = Console.ReadLine();
    if (resposta.ToLower() == "s")
    {
        biblioteca.EmprestarLivro(); // Assumindo que `Livros` é uma propriedade pública que retorna a lista de livros
    }
    else if (resposta.ToLower() == "n")
    {
        break; // Sai do loop se o usuário não quiser emprestar mais
    }
    else
    {
        Console.WriteLine("Resposta inválida. Tente novamente.");
    }

    // Pergunta se o usuário deseja listar os livros emprestados do cliente
    Console.WriteLine("Deseja listar os livros emprestados de um cliente? (s/n)");
    string listarEmprestimos = Console.ReadLine();
    if (listarEmprestimos.ToLower() == "s")
    {
        biblioteca.ListarEmprestimos(); // Chama o método para listar empréstimos
    }

    // Pergunta se o usuário deseja ver a lista geral de livros
    Console.WriteLine("Deseja ver a lista geral de livros? (s/n)");
    string listarLivros = Console.ReadLine();
    if (listarLivros.ToLower() == "s")
    {
        biblioteca.ExibirLista(); // Exibe a lista de livros
    }
}

biblioteca.devolver();

Console.WriteLine("Deseja ver a lista geral de livros? (s/n)");
string listarLivros2 = Console.ReadLine();
if (listarLivros2.ToLower() == "s")
{
    biblioteca.ExibirLista(); // Exibe a lista de livros
}


Console.WriteLine("Sistema encerrado.");
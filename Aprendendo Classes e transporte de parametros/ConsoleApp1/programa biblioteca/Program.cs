
using programa_biblioteca;

biblioteca biblioteca = new biblioteca();

while (true)
{
    Console.WriteLine("use algum comando como \"adicionar\" ou \"exibir\"");
  string comando = Console.ReadLine();

    if (comando == "adicionar")
    {
        biblioteca.AdicionarLivro();
    }
    else if (comando == "exibir")
    {
        biblioteca.ExibirLista();
    }
}

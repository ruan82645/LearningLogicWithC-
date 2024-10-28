// Nesse desafio, devo consumir a Api de dados do The Movie Data Base.
// O objetivo é exibir uma "página" de filmes e perguntar se o usuario deseja continuar vendo
// se disser sim, deve ser exibida outra página

using Desafio_03;

int pagina = 1;
string confirmacao = "";

while (confirmacao != "não")
{
    Api api = new Api();
    Formatar formatar = new Formatar();

    List<Infos> Movies = await api.filmes(pagina);

    foreach (Infos Movie in Movies)
    {
        formatar.Exibir(Movie);
    }

    Console.WriteLine();
    Console.WriteLine("ir para a proxima página? (sim ou não?)");
    confirmacao = Console.ReadLine();

    if(confirmacao.ToLower() == "sim" || confirmacao.ToLower() == "não")
    {
        if (confirmacao == "sim")
        {
            pagina++;
        }
        if (confirmacao == "não")
        {
            break;
        }
    }
    else
    {

    }
    
}


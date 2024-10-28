// Nesse desafio, devo consumir a Api de dados do The Movie Data Base.
// O objetivo é exibir uma "página" de filmes e perguntar se o usuario deseja continuar vendo
// se disser sim, deve ser exibida outra página

using Desafio_03;

int pagina = 1;
bool continuar = true;

while (continuar == true)
{
    Api api = new Api();
    Formatar formatar = new Formatar();
    confirmacao confirmar = new confirmacao();

    Infos Movies = await api.filmes(pagina);

        formatar.Exibir(Movies);


    Console.WriteLine();
    bool proximaPagina = confirmar.Confirmar(continuar);

    if (proximaPagina)
    {
        pagina++;
    }
    else
    {
        continuar = false;
    }
    
}


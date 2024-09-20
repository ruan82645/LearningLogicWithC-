
using ColocandoPropriedadesEmAtributos;

pato patoReginaldo = new pato();

patoReginaldo.name = "Reginaldo";
patoReginaldo.cor = "branco";

try
{
    patoReginaldo.Asas = 4;
    patoReginaldo.Quack();
}
catch(Exception erro)
{
    Console.WriteLine(erro.Message);
    patoReginaldo.Asas = 2;
    patoReginaldo.QuackError();
}



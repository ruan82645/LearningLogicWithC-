// Para comparar datas com o C# também é bem fácil, ele identifica os valores e compara normalmente
// Isso não necessita de muita informação, ou explicação, é apenas comparação de dados
// Devemos ter uma variavel com um valor de Data ou hora para comparar ou criar o DateTime diretamente na comparação

DateTime hoje = DateTime.Now;
DateTime VencimentoFatura = new DateTime(2024, 09, 25);

if (VencimentoFatura < hoje)
{
    Console.WriteLine("conta de luz atrasada");
}
else
{
    Console.WriteLine("Conta de luz em dia");
}

//--------------------------------------------------------------

if(DateTime.Now > new DateTime(2024, 09, 26))
{
    Console.WriteLine("passamos da data de exemplo");
}
else
{
    Console.WriteLine("ainda estamos antes da data de exemplo");
}
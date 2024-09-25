//Creio que esse quase não precise de explicação
//ToUpper deixa em maiusculo e ToLower deixa em minusculo
//não tem muito o que dizer

//ToUpper()

string Exemplo1 = "tudo em maiusculo";
string maiusculo = Exemplo1.ToUpper();
//"TUDO EM MAIUSCULO"

//ToLower()

string Exemplo2 = "TUDO EM MINUSCULO";
string minusculo = Exemplo1.ToUpper();
//"tudo em minusculo"


//Só um exercicio simples então para fixar
//deixar os primeiros caracteres de cada nome em maiusculo e o resto em minusculo
//mas deixando sempre as conexões de nome ("da","do","de") em minusculo

string nome = "lArIsSa rIbEiRo dE sOuSa";

string[] partesNome = nome.Split(' ');

for(int i = 0; i < partesNome.Length; i++)
{
    if (!(partesNome[i].Length <= 2))
    {
        partesNome[i] = 
        partesNome[i].Substring(0, 1).ToUpper() +
        partesNome[i].Substring(1).ToLower();
    }
    else//caso seja uma conexao de nome
    {
        partesNome[i] = partesNome[i].ToLower();
    }
}

string NomeFormatado = string.Join(" ",partesNome);
Console.WriteLine(NomeFormatado);

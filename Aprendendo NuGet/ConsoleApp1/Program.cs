using System.IO;
using System.Text;

// Lê todas as linhas do arquivo original usando a codificação padrão do sistema
string[] linhas = File.ReadAllLines("legenda.txt", Encoding.Default);

// Abre o arquivo de saída usando a mesma codificação
using (StreamWriter escritor = new StreamWriter("legendaCorrigida.txt", false, Encoding.Default))
{
    foreach (string linha in linhas)
    {
        // Remove as tags <i> e </i>
        string linhaCorrigida = linha.Replace("<i>", "").Replace("</i>", "");

        // Escreve a linha corrigida no arquivo de saída
        escritor.WriteLine(linhaCorrigida);
    }
}
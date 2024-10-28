using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic;

namespace Desafio_04
{
    internal class Arquivo
    {
        public void Escrever(string ip)
        {

            string[] linhas = File.ReadAllLines("logip.txt");
            StreamWriter escritor = new StreamWriter("logip.txt");

            DateTime agora = DateTime.Now;

            string texto = $"{agora.ToString("dd/MM/yyyy HH:mm:ss")} - {ip}";

            if (linhas.Length > 0)
            {
                foreach (string line in linhas)
                {
                    escritor.WriteLine(line);
                }
            }

            escritor.WriteLine(texto);
            Console.WriteLine(texto);

            escritor.Close();
        }
    }
}

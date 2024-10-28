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
            DateTime agora = DateTime.Now;

            string texto = $"{agora.ToString("dd/MM/yyyy HH:mm:ss")} - {ip}";

            File.WriteAllText("logip.txt", texto);
        }
    }
}

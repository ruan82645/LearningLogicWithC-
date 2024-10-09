using OfficeOpenXml;
ExcelPackage.LicenseContext = LicenseContext.NonCommercial;


System.IO.StreamReader leitor = new System.IO.StreamReader("texto.txt");
System.IO.MemoryStream stream = new System.IO.MemoryStream();
var package = new ExcelPackage(stream);

ExcelWorksheet aba1 = package.Workbook.Worksheets.Add("aba1");

int il = 1;

while (!leitor.EndOfStream)
{
    string linha = leitor.ReadLine();

    string[] infos = linha.Split(";");

    //ruan;61981853151;Brasil
    //eric;61981851244;Chile
    //Larissa;61949561984;Canada

    for(int i  = 0; i < infos.Length; i++)
    {
        aba1.Cells[il, i+1].Value = infos[i];
    }
    il++;
}

package.Save();
stream.Position = 0;
File.WriteAllBytes("arquivo.xlsx", stream.ToArray());
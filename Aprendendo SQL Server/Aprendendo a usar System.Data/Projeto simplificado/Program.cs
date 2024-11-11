
using Projeto_simplificado;
using System.Data.SqlClient;
using System.Data;


static class MeuPrograma
{
    static void Main()
    {

        AcessoDados db = new AcessoDados(); 

        var clientes = db.ExecutarSql("select * from Clientes");

        foreach(DataRow cliente in clientes.Tables[0].Rows)
        {
            Console.WriteLine(cliente["nome"]);
        }

        db.ExecutarNonSql("Update clientes set email = 'email@gmail.com'");
    }

    
}





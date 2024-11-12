
using Projeto_simplificado;
using System.Data.SqlClient;
using System.Data;


static class MeuPrograma
{
    static void Main()
    {

        Listar listar = new Listar();
        Processar processar = new Processar();  

        listar.ListarClientes();
        listar.exibirMenuNavegacao();
        
        string comando = Console.ReadLine().ToLower();
        int idCliente = 0;

        if (comando.StartsWith("editar"))
        {
            processar.processarEditar(comando);
            
            
        }
        else if (comando.StartsWith("excluir"))
        {
            idCliente = listar.ExtrairIdClienteDoTexto(comando); 

        }
        else
        {
            Console.WriteLine("Comando Inválido");
        }
    }

    
}





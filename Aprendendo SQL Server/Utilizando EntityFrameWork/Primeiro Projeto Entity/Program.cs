﻿
using Projeto_simplificado;
using System.Data.SqlClient;
using System.Data;
using Primeiro_projeto_Entity.Data;

static class MeuPrograma
{
    static void Main()
    {

        Listar listar = new Listar();
        Processar processar = new Processar();

        listar.ListarClientesCompletos();
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






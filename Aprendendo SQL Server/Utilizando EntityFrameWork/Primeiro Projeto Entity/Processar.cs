﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Primeiro_projeto_Entity.Data;
using Primeiro_projeto_Entity.Models;
using Models = Primeiro_projeto_Entity.Models;

namespace Projeto_simplificado
{
    internal class Processar
    {
        BancoTesteContext contexto = new BancoTesteContext();


        Listar listar = new Listar();
        int idCliente = 0;

        public void processarEditar(string comando)
        {
            int idCliente = listar.ExtrairIdClienteDoTexto(comando);

            Console.WriteLine($"digite o nome que deseja alterar do id \"{idCliente}\" ");
            string nome = Console.ReadLine();

            var cliente = contexto.Clientes.Find(idCliente);

            cliente.Nome = nome;

            contexto.SaveChanges();

            listar.ListarClientesCompletos();

        }

        public void ProcessarExcluir(string comando)
        {
            int idCliente = listar.ExtrairIdClienteDoTexto(comando);

            var cliente = contexto.Clientes.Find(idCliente);

            contexto.Remove(cliente);
            contexto.SaveChanges();

            Console.WriteLine($"sucesso, registros deletados");

            listar.ListarClientesCompletos();
        }

        public void ProcessarInserir(string comando)
        {
            string comandoLimpo = listar.LimparComando(comando);

            //{nome}{email}{telefone}{salario}

            string[] DadosInsercao = comandoLimpo.Split(",");

            
            contexto.Clientes.Add(new Models.Cliente()
            {
                Nome = DadosInsercao[1],
                Email = DadosInsercao[2],
                Telefone = DadosInsercao[3],
                Salario = decimal.Parse(DadosInsercao[4])
            });

            contexto.SaveChanges();

            listar.ListarClientesCompletos();
        }
    }
}

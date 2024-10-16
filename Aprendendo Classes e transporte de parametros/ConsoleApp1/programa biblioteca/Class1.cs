using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_biblioteca
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime Publicacao { get; set; }
        public bool status { get; set; }

    }

    public class LivroEmprestado
    {
        public string TituloEmprestimo { get; set; }
        public string AutorEmprestimo { get; set; }
    }

    public class Cliente
    {
        public string nome { get; set; }
        public string cpf { get; set; }

    }
    public class biblioteca
    {

        List<Livro> livros = new List<Livro>();
        List<Cliente> clientes = new List<Cliente>();
        List<LivroEmprestado> Emprestimos = new List<LivroEmprestado>();
        Dictionary<Cliente, List<LivroEmprestado>> Emprestimo = new Dictionary<Cliente, List<LivroEmprestado>>();

        Livro livro1 = new Livro();
        Livro livro2 = new Livro();
        Livro livro3 = new Livro();
      
        public void AdicionarLivro()
        {
            //Console.WriteLine("informe o titulo do novo livro");
            //string tituloInput = Console.ReadLine();
            //string tituloFinal = VerificarTitulo(tituloInput);

            //Console.WriteLine("informe o autor do novo livro");
            //string AutorInput = Console.ReadLine();
            //string AutorFinal = VerificarAutor(AutorInput);

            //Console.WriteLine("Qual a data do lançamento do novo livro?");
            //string dataLancamentoInput = Console.ReadLine();
            //DateTime dataLancamento = VerificarData(dataLancamentoInput);

            AdicionarLivroNaLista();//tituloFinal, AutorFinal, dataLancamento);

            Console.WriteLine("livro adicionado a lista");

        }

        public void AdicionarCliente()
        {
            Console.WriteLine("informe o nome do novo cliente");
            string NomeFinal = Console.ReadLine();

            Console.WriteLine("informe o cpf do novo cliente");
            string CpfInput = Console.ReadLine();
            string CpfVerificado = VerificarCpf(CpfInput);

            CriarCliente(NomeFinal,CpfVerificado);

            Console.WriteLine("cliente criado com sucesso");

        }

        internal string VerificarCpf(string cpf)
        {
            int i = 0;

            if (cpf.Length < 11 || cpf.Length > 14)
            {
                Console.WriteLine("cpf incorreto");
                return VerificarCpf(Console.ReadLine());
            }

            string CpfCorrigido = FormatarCpf(cpf);

            foreach (var cliente in Emprestimo.Keys)
            {
                if (cliente.cpf == CpfCorrigido)
                {
                    i++;
                }
            }
            if (i > 0)
            {
                Console.WriteLine("Cpf ja existe no banco, digite outro cpf");
                return VerificarCpf(Console.ReadLine());
            }
            else
            {
                return CpfCorrigido;
            }

        }

        internal string FormatarCpf(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if(cpf.Length == 11)
            {
                cpf = cpf.Insert(3,".").Insert(7,".").Insert(11,"-");
            }

            return cpf;
        }

        internal void CriarCliente(string nome, string cpf)
        {
           Cliente cliente = new Cliente();

            cliente.nome = nome;
            cliente.cpf = cpf;

            Emprestimo.Add(cliente, new List<LivroEmprestado>());  
        }


        public void EmprestarLivro()
        {
            Cliente clienteEscolhido = SelecionarUsuario(Emprestimo);
            Console.WriteLine();
            Livro livroEscolhido = SelecaoListaLivros();
            
            LivroEmprestado livroEmprestado = new LivroEmprestado();

            livroEmprestado.TituloEmprestimo = livroEscolhido.Titulo;
            livroEmprestado.AutorEmprestimo = livroEscolhido.Autor;

            Emprestimo[clienteEscolhido].Add(livroEmprestado);
        }

        public void ListarEmprestimos()
        {

           Cliente cliente = SelecionarUsuario(Emprestimo);
           
            if (Emprestimo.TryGetValue(cliente, out var livros))
            {
                int i = 1;
                Console.WriteLine("livros emprestados");
                foreach (var livro in livros)
                {

                    Console.WriteLine($"{i} - {livro.TituloEmprestimo}");
                }
            }
            else
            {
                Console.WriteLine("cliente não existe, adicione um cliente");
                AdicionarCliente();
            }

        }
        
        public void devolver()
        {
            Cliente cliente = SelecionarUsuario(Emprestimo);
            int i = 0;
            if (Emprestimo.TryGetValue(cliente, out var livrosEmprestados))
            {
                Console.WriteLine("livros emprestados");
                foreach (var livro in livrosEmprestados)
                {
                    i++;
                    Console.WriteLine($"{i} - {livro.TituloEmprestimo}");

                }
            }
            else
            {
                Console.WriteLine("cliente não existe, adicione um cliente");
                AdicionarCliente();
            }

            int escolha = int.Parse(Console.ReadLine());

            if(escolha <= 0 || escolha > i)
            {
                Console.WriteLine("escolha invalida");
            }
            else
            {
                var livroEmprestado = livrosEmprestados[escolha - 1];
                Emprestimo[cliente].Remove(livroEmprestado);

                foreach(var livro in livros)
                {
                    if (livro.Titulo == livroEmprestado.TituloEmprestimo)
                    {
                        livro.status = true;
                        Console.WriteLine($"{livro.Titulo} disponivel novamente");
                    }
                }
            }
        }

        internal Livro SelecaoListaLivros()
        {
            int i = 1;

            foreach (var livro in livros)
            {
                if (livro.status == true)
                {
                    Console.WriteLine($@"{i} - titulo: {livro.Titulo}, 
                autor: {livro.Autor}, 
                Publicacao: {livro.Publicacao.ToString("dd/MM/yyyy")}
                Status: disponivel");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($@"{i} - titulo: {livro.Titulo}, 
                autor: {livro.Autor}, 
                Publicacao: {livro.Publicacao.ToString("dd/MM/yyyy")}
                Status: emprestado");
                    Console.WriteLine();
                }
                i++;
            }

            int escolha = int.Parse(Console.ReadLine());

            if (escolha < 1 || escolha > i)
            {
                Console.WriteLine("esse livro não existe ou já está emprestado");
                return SelecaoListaLivros();
            }
            else if(livros[escolha-1].status == true)
            {
                Livro livroEscolhilho = livros[escolha];
                livroEscolhilho.status = false;
                return livroEscolhilho;
            }
            else
            {
                Console.WriteLine("livro emprestado");
                return SelecaoListaLivros();
            }
        }

        internal Cliente SelecionarUsuario(Dictionary<Cliente, List<LivroEmprestado>> emprestimo)
        {
            int i = 1;
            Console.WriteLine("Escolha um cliente");
            foreach (Cliente cliente in emprestimo.Keys)
            {

                Console.WriteLine($"{i} - {cliente.nome}");
                i++;
            }

            int escolha = int.Parse(Console.ReadLine());

            if (escolha < 1 || escolha > i)
            {
                Console.WriteLine("essa pessoa não existe");
                return SelecionarUsuario(emprestimo);
            }
            else
            {
                var clienteEscolhido = emprestimo.Keys.ElementAt(escolha-1);
                return clienteEscolhido;
            }
            
        } 


        

        internal void AdicionarLivroNaLista()//string tituloFinal, string AutorFinal,DateTime dataLancamento)
        {
            //Livro livro = new Livro();

            livro1.Titulo = "sertanejo";
            livro1.Autor = "jorge e mateus";
            livro1.Publicacao = new DateTime(10/12/1995);
            livro1.status = true;

            livro2.Titulo = "computadores";
            livro2.Autor = "jorge cursos";
            livro2.Publicacao = new DateTime(10 / 07 / 2021);
            livro2.status = true;

            livro3.Titulo = "risos";
            livro3.Autor = "Leo Lins";
            livro3.Publicacao = new DateTime(25 / 03 / 2019);
            livro3.status = true;

            //livro.Titulo = tituloFinal;
            //livro.Autor = AutorFinal;
            //livro.Publicacao = dataLancamento;
            //livro.status = true;

            //livros.Add(livro);
            livros.Add(livro1);
            livros.Add(livro2);
            livros.Add(livro3);
        }

        internal string VerificarTitulo(string tituloInput)
        {
            int i = 0;

            foreach (var livro in livros) 
            {

                if(livro.Titulo == tituloInput)
                {
                    i++;
                }
            }

            if (i > 0)
            {
                Console.WriteLine("esse livro já existe, por favor, digite outro");
                return VerificarTitulo(Console.ReadLine());
            }
            else
            {
                return tituloInput;
            }
        }

        internal DateTime VerificarData(string dataLancamentoInput)
        {
            bool sucesso = DateTime.TryParse(dataLancamentoInput, out DateTime resultado);

            if (sucesso)
            {
                return resultado;
            }
            else
            {
                Console.WriteLine("informe uma data válida");
                return VerificarData(Console.ReadLine());
            }
        }

        internal string VerificarAutor(string autorInput)
        {
            if(!(autorInput == null || autorInput == ""))
            {
                return autorInput;
            }
            else
            {
                Console.WriteLine("digite um autor");
                return VerificarAutor(Console.ReadLine());
            }
            
        }

        public void ExibirLista()
        {
            int i = 0;

            foreach(var livro in livros)
            {
                if(livro.status == true)
                {
                Console.WriteLine($@"{i} - titulo: {livro.Titulo}, 
                autor: {livro.Autor}, 
                Publicacao: {livro.Publicacao.ToString("dd/MM/yyyy")}
                Status: disponivel");
                Console.WriteLine();
                }
                else
                {
                Console.WriteLine($@"{i} - titulo: {livro.Titulo}, 
                autor: {livro.Autor}, 
                Publicacao: {livro.Publicacao.ToString("dd/MM/yyyy")}
                Status: emprestado");
                Console.WriteLine();
                }

                i++;
                
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using DIO.Series.Classes;
using DIO.Series.Enum;

namespace DIO.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------");
            string opcao = ObterOpcaoUsuario();

            while(opcao.ToUpper() != "X"){
                switch(opcao)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VizualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                opcao = ObterOpcaoUsuario();
            }
        }
        private static void AtualizarSerie()
        {
            Serie serie = null;
            SerieRepositorio sr = new SerieRepositorio();

            Console.WriteLine("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Titulo: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Descricao: ");
            string descricao = Console.ReadLine();

            Console.WriteLine("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Genero: 1->Acao, 2->Aventura, 3->Comedia, 4->Documentario, 5->Drama");
            int genero = int.Parse(Console.ReadLine());
            
            Genero g = new Genero();

            if(genero == 1)
            {
                g = Genero.Acao;
            } else if(genero == 2)
            {
                g = Genero.Aventura;
            } else if(genero == 3)
            {
                g = Genero.Comedia;
            } else if(genero == 4)
            {
                g = Genero.Documentario;
            } else if(genero == 5)
            {
                g = Genero.Drama;
            }
            

           serie = new Serie(id, titulo, descricao, ano, g);
           sr.Atualizar(id, serie);
           
        }
        private static void VizualizarSerie()
        {
            SerieRepositorio sr = new SerieRepositorio(); 
            Serie serie = null;

            Console.WriteLine("Informe o Id: ");
            int id = int.Parse(Console.ReadLine());

            serie = sr.RetornaPorId(id);

            Console.WriteLine("#Id {0}: - {1}", serie.retornaInt(), serie.retornaTitulo());

        }
        private static void ExcluirSerie()
        {
            SerieRepositorio sr = new SerieRepositorio(); 

            Console.WriteLine("Informe o Id: ");
            int id = int.Parse(Console.ReadLine());
            sr.Excluir(id);

        }
        private static void ListarSeries()
        {
            SerieRepositorio sr = new SerieRepositorio();
            foreach(Serie s in sr.Lista())
            {
                Console.WriteLine("#Id {0}: - {1}", s.retornaInt(), s.retornaTitulo());
            }
            
        }
        private static void InserirSerie()
        {
            Serie serie = null;
            SerieRepositorio sr = new SerieRepositorio();

            Console.WriteLine("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Titulo: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Descricao: ");
            string descricao = Console.ReadLine();

            Console.WriteLine("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Genero: 1->Acao, 2->Aventura, 3->Comedia, 4->Documentario, 5->Drama");
            int genero = int.Parse(Console.ReadLine());
            
            Genero g = new Genero();

            if(genero == 1)
            {
                g = Genero.Acao;
            } else if(genero == 2)
            {
                g = Genero.Aventura;
            } else if(genero == 3)
            {
                g = Genero.Comedia;
            } else if(genero == 4)
            {
                g = Genero.Documentario;
            } else if(genero == 5)
            {
                g = Genero.Drama;
            }
            

           serie = new Serie(id, titulo, descricao, ano, g);
           sr.Insere(serie);          
           

        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");

            string opcao = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcao;
        }
    }
}

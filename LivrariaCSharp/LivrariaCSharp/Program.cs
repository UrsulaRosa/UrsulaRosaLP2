using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Livro> livros = new List<Livro>();
        Menu:
            Console.Clear();
            Console.WriteLine("Menu: \n 1.Cadastrar \n 2.Consultar \n 3.Alterar \n 4.Remover \n 5.Sair \n ----------");
            int opcao = int.Parse(Console.ReadLine());
            /*Cadastrar*/
            if (opcao == 1)
            {
            cadastrar:
                Console.Clear();
                Console.Write("Quantos livros à cadastrar? ");
                int cadastrarLivros = int.Parse(Console.ReadLine());
                for (int i = livros.Count; i < cadastrarLivros; i++)
                {
                    Console.Clear();
                    Livro l = new Livro();
                    Console.Write("Nome do Livro: ");
                    l.NomeLivro = Console.ReadLine();
                    Console.Write("Autor: ");
                    l.Autor = Console.ReadLine();
                    Console.Write("Genero: ");
                    l.Genero = Console.ReadLine();
                    Console.Write("ISBN: ");
                    l.Isbn = Console.ReadLine();
                    Console.Write("Quantidade: ");
                    l.Quantidade = int.Parse(Console.ReadLine());
                    Console.Write("Preço: ");
                    l.Preco = double.Parse(Console.ReadLine());
                    livros.Add(l);
                }
                Console.WriteLine("cadastrar mais Livros? 1- Sim 2-Não");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                    goto cadastrar;
                if (opcao == 2)
                    goto Menu;
                goto Menu;
            }
            /*Consultar*/
            if (opcao == 2)
            {
                Console.Clear();
                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();
                int i = 0;
                bool aux = true;
                while (aux)
                {
                    if (isbn == livros[i].Isbn)
                    {
                        Console.WriteLine("Nome: " + livros[i].NomeLivro);
                        Console.WriteLine("Autor: " + livros[i].Autor);
                        Console.WriteLine("Genero: " + livros[i].Genero);
                        Console.WriteLine("ISBN: " + livros[i].Isbn);
                        Console.WriteLine("Quantidade: " + livros[i].Quantidade);
                        Console.WriteLine("Preço: " + livros[i].Preco);
                        aux = false;
                    }
                    else
                    {
                        Console.WriteLine("Livro não encontrado!");
                        

                    }
                    i++;
                }
                Console.ReadKey();
                goto Menu;
            }
            /*Alterar*/
            if (opcao == 3)
            {
                Console.Clear();
                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();
                int i = 0;
                bool aux = true;
                while (aux)
                {
                    if (isbn == livros[i].Isbn)
                    {
                        Console.WriteLine("Nome: " + livros[i].NomeLivro);
                        Console.WriteLine("Autor: " + livros[i].Autor);
                        Console.WriteLine("Genero: " + livros[i].Genero);
                        Console.WriteLine("ISBN: " + livros[i].Isbn);
                        Console.WriteLine("Quantidade: " + livros[i].Quantidade);
                        Console.WriteLine("Preço: " + livros[i].Preco);
                        Console.WriteLine("\n O que deseja mudar?  \n 1.Nome do Livro \n 2.Autor \n 3.Genero \n 4.ISBN \n 5.Quantidade \n 6.Preço \n -----------------");
                        opcao = int.Parse(Console.ReadLine());
                        if (opcao == 1)
                        {
                            Console.Write("Nome do Livro: ");
                            livros[i].NomeLivro = Console.ReadLine();
                        }
                        if (opcao == 2)
                        {
                            Console.Write("Autor: ");
                            livros[i].Autor = Console.ReadLine();
                        }
                        if (opcao == 3)
                        {
                            Console.Write("Genero: ");
                            livros[i].Genero = Console.ReadLine();
                        }
                        if (opcao == 4)
                        {
                            Console.Write("ISBN: ");
                            livros[i].Isbn = Console.ReadLine();
                        }
                        if (opcao == 5)
                        {
                            Console.Write("Quantidade: ");
                            livros[i].Quantidade = int.Parse(Console.ReadLine());
                        }
                        if (opcao == 6)
                        {
                            Console.Write("Preço: ");
                            livros[i].Preco = double.Parse(Console.ReadLine());
                        }
                        aux = false;
                    }
                    if (i == livros.Count - 1)
                    {
                        Console.WriteLine("Livro não encontrado!");
                        aux = false;
                    }
                    i++;
                }
                goto Menu;
            }
            /*Remover*/
            if (opcao == 4)
            {
                Console.Clear();
                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();
                int i = 0;
                bool aux = true;
                while (aux)
                {
                    if (isbn == livros[i].Isbn)
                    {
                        Console.WriteLine("Nome: " + livros[i].NomeLivro);
                        Console.WriteLine("Autor: " + livros[i].Autor);
                        Console.WriteLine("Genero: " + livros[i].Genero);
                        Console.WriteLine("ISBN: " + livros[i].Isbn);
                        Console.WriteLine("Quantidade: " + livros[i].Quantidade);
                        Console.WriteLine("Preço: " + livros[i].Preco);
                        Console.WriteLine("\n Deseja remover este livro? 1-Sim 2-Não");
                        opcao = int.Parse(Console.ReadLine());
                        if (opcao == 1)
                            livros.Remove(livros[i]);
                        else
                            goto Menu;
                        aux = false;
                    }
                    if (i == livros.Count - 1)
                    {
                        Console.WriteLine("Livro não encontrado!");
                        aux = false;
                    }
                }
                Console.ReadKey();
                goto Menu;
            }
            /* Sair*/
            if (opcao == 5) { }
        }
    }
}

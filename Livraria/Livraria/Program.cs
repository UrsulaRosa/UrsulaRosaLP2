using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Menu: \n 1. Cadastrar \n 2. Consultar \n 3. Alterar \n 4. Remover \n 5. Sair \n ----------- ");
            int menu = int.Parse(Console.ReadLine());
            Livro l = new Livro();
            if (menu == 1)
                l.Cadastrar();
            if (menu == 2)
                l.Consultar();
            if (menu == 3)
                l.Alterar();
            if (menu == 4)
                l.Remover();
            if (menu == 5)
                Environment.Exit(menu);
        }
    }
}

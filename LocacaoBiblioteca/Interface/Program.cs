using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locacao.Controller;
using Locacao.Model;

namespace Interface
{
    class Program
    {
        static List<Livro> livros = new List<Livro>() {
            new Livro(0,"the bomberman", true),
            new Livro(1,"the fisherman", true),
            new Livro(2,"the joker master", true),
        };
        static List<Usuario> usuarios = new List<Usuario>() {
            new Usuario("Gian", "1234"),
            new Usuario("Pedro", "5522")
        };

        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS (Beta 0.5)");
            while (!RealizaLoginSistema())
            {
                Console.WriteLine("Login ou senha errado");
            }
            MenuSistema();
            Console.ReadKey();
        }

        private static void MenuSistema()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu Sistema");
                Console.WriteLine("1 - Procurar livro");
                Console.WriteLine("2 - Ver livros locados");
                Console.WriteLine("0 - Sair");
                var Menu = Console.ReadLine();
                switch (Menu)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("Informe o titulo do livro: ");
                        Livro livro = GetLivro(Console.ReadLine());
                        if (livro != null)
                        {
                            Console.WriteLine(livro.ToString());
                            Console.WriteLine("Deseja alocar este livro? (sim, nao)");
                            if (Console.ReadLine().Equals("sim")) {
                                if (livro.Disponivel) {

                                }
                            }
                            Console.ReadKey();
                        }
                        else {
                            Console.WriteLine("Livro nao encontrado");
                            Console.ReadKey();
                            return;
                        }
                        break;
                    case "2":
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// este metodo retorna se o usuario logou com sucesso.
        /// </summary>
        /// <returns></returns>
        private static bool RealizaLoginSistema()
        {
            Console.WriteLine("Informe suas informações de Acesso");
            Console.Write("Login: ");
            var login = Console.ReadLine();
            Console.Write("Senha: ");
            var senha = Console.ReadLine();
            return usuarios.Any(i => i.Login == login && i.Senha == senha);
        }
        private static Livro GetLivro(string nome) {
            foreach (var item in livros)
            {
                if (item.Titulo.Equals(nome)) {
                    return item;
                }
            }
            return null;
        }
    }
}

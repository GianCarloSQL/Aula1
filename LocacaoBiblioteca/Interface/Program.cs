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
        static UsuarioController usuarioControl = new UsuarioController();
        static LivroController livroControl = new LivroController();
        static Usuario currently = null;
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS (Beta 1.1)");
            Loga();
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
                Console.WriteLine("3 - Cadastrar Livro");
                Console.WriteLine("4 - Adicionar usuario");
                Console.WriteLine("5 - Deslogar");
                Console.WriteLine("6 - Remover usuario");
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
                                if (livro.Disponivel)
                                {
                                    livro.Disponivel = false;
                                    currently.livros.Add(livro);
                                }
                                else {
                                    Console.WriteLine("Livro não disponivel.");
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
                    case "3":
                        AdicionaLivro();
                        break;
                    case "2":
                        Console.WriteLine("Os seus livros locados são:");
                        currently.livros.ForEach(i => Console.WriteLine(i.Titulo));
                        Console.ReadKey();
                        break;
                    case "4":
                        AdicionaUsuario();
                        break;
                    case "5":
                        if (currently != null)
                        {
                            currently = null;
                            Console.WriteLine("Deslogado com sucesso!");
                        }
                        Console.ReadKey();
                        Loga();
                        break;
                        case "6":
                        remover();
                        break;
                    default:
                        break;
                }
            }
        }

        private static void AdicionaUsuario()
        {
            Console.WriteLine("Nome do usuario:");
            var nome = Console.ReadLine();
            Console.WriteLine("Senha");
            var senha = Console.ReadLine();
            Usuario u = new Usuario(nome, senha);
            usuarioControl.AdicionaUsuario(u);
        }

        /// <summary>
        /// este metodo retorna se o usuario logou com sucesso.
        /// </summary>
        /// <returns></returns>
        private static Usuario RealizaLoginSistema()
        {
            Console.WriteLine("Informe suas informações de Acesso");
            Console.Write("Login: ");
            var login = Console.ReadLine();
            Console.Write("Senha: ");
            var senha = Console.ReadLine();
            return usuarioControl.GetUsuarios().Find(i => i.Login == login && i.Senha == senha);
        }
        private static Livro GetLivro(string nome) {
            foreach (var item in livroControl.GetLivros())
            {
                if (item.Titulo.Equals(nome)) {
                    return item;
                }
            }
            return null;
        }

        private static void AdicionaLivro() {
            Console.WriteLine("Cadastrar Livro no Sistema");
            Console.WriteLine("Nome do Livro:");
            var nome = Console.ReadLine();
            livroControl.AdicionaLivro(new Livro(nome));
            Console.WriteLine("Livro Cadastrado!");
            Console.ReadKey();
        }
        public static void Loga() {
            do
            {
                currently = RealizaLoginSistema();
            } while (currently == null);
            MenuSistema();
        }
        public static void remover() {
            Console.WriteLine("Digite o ID do usuario a remover");
            usuarioControl.GetUsuarios().ForEach(i => Console.WriteLine($"{i.Login}\n {i.Id}"));
            var u = Console.ReadLine();
            usuarioControl.RemoveUsuario(usuarioControl.GetUsuarios()[int.Parse(u)]);
            Console.WriteLine("Usuario removido com sucesso");
            Console.ReadKey();
        }
    }
}

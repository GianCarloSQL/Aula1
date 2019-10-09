using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Locacao.Controller;
using Locacao.Model;

namespace Interface
{
    class Program
    {
        static Task Loading = new Task(ProgressBar);
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
                Console.WriteLine("7 - Remover Livro");
                Console.WriteLine("8 - Listar");
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
                            if (Console.ReadLine().Equals("sim"))
                            {
                                if (livro.Disponivel)
                                {


                                    livro.Disponivel = false;
                                    currently.livros.Add(livro);
                                }
                                else
                                {
                                    Console.WriteLine("Livro não disponivel.");
                                }
                            }
                            Console.ReadKey();
                        }
                        else
                        {
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
                        RemoverUsuario();
                        break;
                    case "7":
                        RemoverLivro();
                        break;
                    case "8":
                        Console.WriteLine("1 - livros | 2 - usuarios");
                        if (int.Parse(Console.ReadLine()) == 1)
                        {
                            Console.WriteLine("ID           Titulo                                Disponivel?");
                            livroControl.GetLista().ToList().ForEach(l => Console.WriteLine(l.ToString()));
                        }
                        else
                        {
                            Console.WriteLine("Login                  Senha");
                            usuarioControl.GetLista().ToList().ForEach(u => Console.WriteLine(u.ToString()));
                        }
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }
        }

        private static void RemoverLivro()
        {

            Console.WriteLine("Remover Livro no Sistema");
            Console.WriteLine("Nome do Livro:");
            var nome = Console.ReadLine();
            livroControl.GetLista().ToList().ForEach(i => Console.WriteLine($"Login: {i.Titulo} ID: {i.Id}"));
            var u = int.Parse(Console.ReadLine());
            var liv = livroControl.GetLista().FirstOrDefault(x => x.Id == u);
            livroControl.Deleta(liv);
            Console.WriteLine("Livro Removido com sucesso!");
            Console.ReadKey();
        }

        private static void AdicionaUsuario()
        {
            Console.WriteLine("Nome do usuario:");
            var nome = Console.ReadLine();
            Console.WriteLine("Senha");
            var senha = Console.ReadLine();
            Usuario u = new Usuario(nome, senha);
            usuarioControl.Inserir(u);
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
            Loading.Start();
            return usuarioControl.GetLista().FirstOrDefault(i => i.Login == login && i.Senha == senha);
        }
        private static Livro GetLivro(string nome)
        {
            foreach (var item in livroControl.GetLista())
            {
                if (item.Titulo.Equals(nome))
                {
                    return item;
                }
            }
            return null;
        }

        private static void AdicionaLivro()
        {
            Console.WriteLine("Cadastrar Livro no Sistema");
            Console.WriteLine("Nome do Livro:");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe o codigo do livro");
            var cod = int.Parse(Console.ReadLine());
            livroControl.Inserir(new Livro(cod, nome));
            Console.WriteLine("Livro Cadastrado!");
            Console.ReadKey();
        }
        public static void Loga()
        {
            do
            {
                currently = RealizaLoginSistema();

            } while (currently == null);
            MenuSistema();
        }
        public static void ProgressBar()
        {
            Console.Clear();
            Console.WriteLine("Wait");
            for (int i = 0; i < 22; i++)
            {
                var b = "_";
                Console.Write(b);
                Thread.Sleep(100);
                b += "_";
            }
            Console.Clear();

        }

        public static void RemoverUsuario()
        {
            Console.WriteLine("Digite o ID do usuario a remover");
            usuarioControl.GetLista().ToList().ForEach(i => Console.WriteLine($"Login: {i.Login} ID: {i.Id}"));
            var u = int.Parse(Console.ReadLine());
            var usu = usuarioControl.GetLista().FirstOrDefault(x => x.Id == u);
            usuarioControl.Deleta(usu);
            Console.WriteLine("Usuario removido com sucesso");
            Console.ReadKey();
        }

    }
}

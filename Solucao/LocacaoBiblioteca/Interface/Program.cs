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
        static bool IsFinished = false;
        //  static Task<Usuario> Logar = new Task<Usuario>(RealizaLoginSistema);
        static UsuarioController usuarioControl = new UsuarioController();
        static LivroController livroControl = new LivroController();
        static Usuario currently = null;
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS (Beta 2.2)");
            Loga();
            Loading.Dispose();
            MenuSistema();
            Console.ReadKey();
        }

        private static void MenuSistema()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("MENU SISTEMA");
                Console.WriteLine($"Bem vindo {currently.Login} o que deseja fazer?");
                Console.WriteLine("1 - Procurar livro");
                Console.WriteLine("2 - Ver livros locados");
                Console.WriteLine("3 - Cadastrar Livro");
                Console.WriteLine("4 - Adicionar usuario");
                Console.WriteLine("5 - Deslogar");
                Console.WriteLine("6 - Remover usuario");
                Console.WriteLine("7 - Remover Livro");
                Console.WriteLine("8 - Listar");
                Console.WriteLine("9 - Atualizar");
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
                        Listar();
                        break;
                    case "9":
                        Update();
                        break;
                    default:
                        break;
                }
            }
        }

        private static void Update()
        {
            Console.WriteLine("1 - livros | 2 - usuarios");
            if (int.Parse(Console.ReadLine()) == 1)
            {
                Console.WriteLine("ID           Titulo                                Disponivel?");
                livroControl.GetLista().ToList().ForEach(l => Console.WriteLine(l.ToString()));
                Console.WriteLine("Informe o ID do Livro que voce deseja alterar");
                var o = int.Parse(Console.ReadLine());
                Livro temp = livroControl.GetLista().FirstOrDefault(l => l.Id == o);
                if (temp != null)
                {
                    Console.WriteLine($"Informe as informações atualizadas do livro {temp.Titulo}");
                    temp.Titulo = Console.ReadLine();
                    Console.WriteLine("Informe o codigo");
                    temp.CodLivro = int.Parse(Console.ReadLine());
                    livroControl.Atualiza(temp);
                    Console.WriteLine("livro atualizado!");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Este livro nao existe");
                    Console.ReadKey(true);
                }
            }
            else
            {
                Console.WriteLine("ID                   Login                  Senha");
                usuarioControl.GetLista().ToList().ForEach(u => Console.WriteLine(u.ToString()));
                Console.WriteLine("Informe o ID do Usuario que voce deseja alterar");
                var o = int.Parse(Console.ReadLine());
                Usuario temp = usuarioControl.GetLista().FirstOrDefault(l => l.Id == o);
                if (temp != null)
                {
                    Console.WriteLine($"Informe o novo Login do Usuario {temp.Login}");
                    temp.Login = Console.ReadLine();
                    Console.WriteLine("Informe a nova senha");
                    temp.Senha = Console.ReadLine();
                    usuarioControl.Atualiza(temp);
                    Console.WriteLine("Usuario atualizado!");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Este Usuario nao existe");
                    Console.ReadKey(true);
                }
            }
        }

        private static void Listar()
        {
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
            Console.Clear();
            IsFinished = true;
            Console.WriteLine("Informe suas informações de Acesso");
            Console.Write("Login: ");
            var login = Console.ReadLine();
            Console.Write("Senha: ");
            var senha = Console.ReadLine();
            IsFinished = false;
            Loading = new Task(ProgressBar);
            Loading.Start();
            Console.Clear();
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
            IsFinished = true;
            MenuSistema();
        }
        public static void ProgressBar()
        {
            Console.Clear();
            Console.Write("Logando");
            while (true)
            {

                if (IsFinished)
                {
                    IsFinished = false;
                    break;
                }
                var b = "_";
                Console.Write(b);
                Thread.Sleep(100);
                b += "_";
            }


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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CelularLibrary.Model;
using SistemaCelularesBackEnd.Control;

namespace View
{
    class Program
    {
        public static CelController CelularControl = new CelController();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha um Menu");
                Console.WriteLine("1 - Inserir Celular");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Update");
                Console.WriteLine("0 - Sair");
                var opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        AdicionarCelular();
                        break;
                    case 2:
                        CelularControl.GetLista().ToList().ForEach(x => Console.WriteLine((x.ToString())));
                        break;
                    case 3:
                        CelularControl.GetLista().ToList().ForEach(x => Console.WriteLine((x.ToString())));
                        Console.WriteLine("Informe o ID para alterar");
                        var a = int.Parse(Console.ReadLine());
                        var c = CelularControl.GetLista().FirstOrDefault(x => x.Id == a);
                        Console.WriteLine("Informe o Marca:");
                        c.Marca = Console.ReadLine();
                        Console.WriteLine("Informe o Modelo:");
                        c.Modelo = Console.ReadLine();
                        CelularControl.Atualiza(c);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey(true);
            }

        }

        public static void AdicionarCelular()
        {
            Console.WriteLine("Cadastrar Celular");
            Console.WriteLine("Informe o Marca:");
            var marca = Console.ReadLine();
            Console.WriteLine("Informe o Modelo:");
            var modelo = Console.ReadLine();
            Console.WriteLine("Informe o Valor do aparelho:");
            var preco = double.Parse(Console.ReadLine());

            var resultado = CelularControl.Inserir(new Celular()
            {
                Marca = marca,
                Modelo = modelo,
                Preco = preco
            });
            if (resultado)
                Console.WriteLine("Celular cadastrado com sucesso!");
            else
                Console.WriteLine("Erro ao cadastrar aparelho...");

        }

    }
}

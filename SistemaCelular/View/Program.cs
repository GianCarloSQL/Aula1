using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CelularLibrary.Control;
using CelularLibrary.Model;
namespace View
{
    class Program
    {
        public static CelularController CelularControl = new CelularController();

        static void Main(string[] args)
        {
            var opcao = int.MinValue;
            while (opcao != 0)
            {
                Console.WriteLine("Escolha um Menu");
                Console.WriteLine("1 - Inserir Celular");
                Console.WriteLine("0 - Sair");
                switch (opcao)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        AdicionarCelular();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey(true);
            }






            if (new Celular().GetType() == typeof(Celular)) { }
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

            var resultado = CelularControl.InserirCelular(new Celular()
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

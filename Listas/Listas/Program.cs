using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {

        static Lista<string> minhaListaPulgmatica = new Lista<string>();

        public static void Main(string[] args)
        {
            AdicionarItensALista();
            ListaInformacoes();
            Thread.Sleep(10000000);

        }

        public static void testeLista()
        {
            Lista<int> lista = new Lista<int>();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            Console.WriteLine(lista.GetAll());
            Thread.Sleep(100000);
        }
        private static void AdicionarItensALista()
        {
            Console.WriteLine("Informe um nome:");
            minhaListaPulgmatica.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Deseja informar mais valores? sim(S) não (N)");
            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s")
                AdicionarItensALista();

        }


        /// <summary>
        /// Metodo que mostra a lista 
        /// </summary>
        private static void ListaInformacoes()
        {
            Console.Clear();
            Console.WriteLine( minhaListaPulgmatica.GetAll());
        }
    }

}


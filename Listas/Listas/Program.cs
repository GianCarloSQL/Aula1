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

        static ListaEncadeada<string> minhaListaPulgmatica = new ListaEncadeada<string>();

        public static void Main(string[] args)
        {
            AdicionarItensALista();
            ListaInformacoes();
            Thread.Sleep(10000000);
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

        private static void ListaInformacoes()
        {
            Console.Clear();
            Console.WriteLine("Itens da Lista: ");
            Console.WriteLine(minhaListaPulgmatica.GetAll());
        }
    }

}


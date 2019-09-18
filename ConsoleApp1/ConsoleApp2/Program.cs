using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using Bibliotecas;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

          //  new Calculos().DoSomething(new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }).ForEach(i => Console.WriteLine(i));
              List<int> lista = new List<int>();
           // lista.Add(0);
            Console.WriteLine($"Qtd Elementos : {lista.Count}\nTamanho       : {lista.Capacity}");
        }
    }
}

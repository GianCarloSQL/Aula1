using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryFlower.Controller;
using LibraryFlower.Model;
namespace View
{
    class Program
    {
        static FlorController Control = new FlorController();
        static void Main(string[] args)
        {
            Control.GetCervejas().OrderByDescending(x => x.Quantidade).ToList().ForEach(f => Console.WriteLine($"{f.Nome}   |   {f.Quantidade}"));
            var qtd = 0;
            Control.GetCervejas().ToList().ForEach(x => qtd += x.Quantidade);
            Console.WriteLine("Quantidade: "+qtd);
            Console.ReadKey();
        }
    }
}

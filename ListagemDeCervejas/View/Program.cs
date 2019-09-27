using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;
namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            Cerveja[] cers = new Cerveja[1] { new Cerveja("Brahma", 1, 1, 1) };
            CervejaController controller = new CervejaController();
            Stack<Cerveja> lista = new Stack<Cerveja>();
            lista.Push(new Cerveja("Skol beats", 1, 1, 1));
            lista.Push(new Cerveja("bbbb", 2, 2, 2));
            lista.Push(new Cerveja("cccc", 3, 3, 3));
            controller.AdicionaCerveja(lista);
            controller.AdicionaCerveja(cers);
            controller.ListaCervejas();
            Console.WriteLine(controller.IsPresso(50));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;

namespace ExternalDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            CervejaController controller = new CervejaController();
            controller.GetCervejas().ForEach(c => Console.WriteLine(c.Nome));
            Console.ReadKey();
        }
    }
}

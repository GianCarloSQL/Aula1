using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Controller;
namespace ListarCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            new CarroController().GetCarro().ForEach(x => Console.WriteLine(x.Marca));
            Console.ReadKey();
        }
    }
}

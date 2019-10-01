using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Listas.Program.CovertCoin(100.0, Listas.TipoMoeda.DOLAR));
            Console.ReadKey();
        }
    }
}

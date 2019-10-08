using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Controller;
using Library.Model;
namespace View
{
    class Program
    {
        static CervejaController control = new CervejaController();
        static void Main(string[] args)
        {
            control.AddCerveja(new Cerveja() { Nome = "Stella"});
            Console.ReadKey();
        }
    }
}

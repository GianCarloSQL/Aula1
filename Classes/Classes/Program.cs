using Classes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Pessoa p;
            p = new PessoaFisica();
            Console.WriteLine(p.GetImposto(10));
            p = new PessoaJuridica();
            Console.WriteLine(p.GetImposto(10));
            */
            CestaFrutas cesta =new CestaFrutas();
            cesta.add("Tomate");
            cesta.add("banana");



            Console.ReadKey();
        }
    }
}

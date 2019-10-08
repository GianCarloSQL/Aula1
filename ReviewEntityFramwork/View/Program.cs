using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Model;
using BackEnd.Controller;
using System.Threading;

namespace View
{
    class Program
    {
        static CervejaController CervejaControl = new CervejaController();

        static void Main(string[] args)
        {
            Task c = new Task(CadastraCerveja);
            Task m = new Task(MostrarCervejas);
            c.Start();
            c.Wait();
            m.Start();
            Console.ReadKey();

        }
        static void MostrarCervejas()
        {
            CervejaControl.GetCervejas().ToList().ForEach(c => Console.WriteLine(c.ToString()));
        }
        static void CadastraCerveja()
        {
            for (int i = 0; i < 10; i++)
            {
                CervejaControl.AddCerveja(new Cerveja($"Cerveja {i}", $"Tipo {i}"));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileControl;
using MercadoTech.Controller;
using MercadoTech.Model;

namespace ViewTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ReaderImpl reader = new ReaderImpl();
            //reader.ExecellReader("C:\\Users\\900092\\Desktop\\Marcas_Modelo_MotoFix.xlsx");
            //    reader.ExcellReader("C:\\Users\\900092\\Desktop\\Marcas_Modelo_AutomovelFix.xlsx");
            CorController controller = new CorController();
            controller.PutCor(0, new Cor()
            {
                Nome = "Azul",
                Codigo = 0
                
            });
            Console.WriteLine(controller.GetCor(1).Nome);
            Console.ReadKey();
        }
    }
}

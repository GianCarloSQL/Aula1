using FileControl;
using MercadoTech.Controller;
using MercadoTech.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            ReaderImpl reader = new ReaderImpl();
            //reader.ExecellReader("C:\\Users\\900092\\Desktop\\Marcas_Modelo_MotoFix.xlsx");
            //    reader.ExcellReader("C:\\Users\\900092\\Desktop\\Marcas_Modelo_AutomovelFix.xlsx");
            CorController controller = new CorController();
            /*  controller.PutCor(new Cor()
              {
                  Nome = "Azul",
                  Codigo = 2

              });*/
           // Console.WriteLine(controller.GetCor().ToList().First(x => x.Ativo).Nome);
            Console.ReadKey();
        }
    }
}

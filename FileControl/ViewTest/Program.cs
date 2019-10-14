using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileControl;

namespace ViewTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ReaderImpl reader = new ReaderImpl();
            //reader.ExecellReader("C:\\Users\\900092\\Desktop\\Marcas_Modelo_MotoFix.xlsx");
            reader.ExcellReader("C:\\Users\\900092\\Desktop\\Marcas_Modelo_AutomovelFix.xlsx");
            Console.ReadKey();
        }
    }
}

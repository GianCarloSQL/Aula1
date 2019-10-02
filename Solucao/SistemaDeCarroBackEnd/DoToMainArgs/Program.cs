using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoToMainArgs
{
    class Program
    {

        static void Main(string[] args)
        {
            List<object> lista = new List<object>()
            {0,1,2,3,4,5};
            lista.ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
    }
}

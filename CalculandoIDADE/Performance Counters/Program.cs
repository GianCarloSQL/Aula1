using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Performance_Counters
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in typeof(Teste).GetProperties())
            {
                Console.WriteLine(item.Name + "         |       " +item.PropertyType);
            }


            Console.ReadKey();
        }

        class Teste {
            public int MyProperty { get; set; }
            public  List<int> lista { get; set; }
            public string txt { get; set; }
            public Composicao Comp { get; set; }
        }
        class Composicao {
            public int MyProperty { get; set; }
        }


    }
}

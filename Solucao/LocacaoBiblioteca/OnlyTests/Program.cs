using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnlyTests
{
    class Program
    {
        static string x = "";
        static void Main(string[] args)
        {
            Task t1 = new Task(Show);
            t1.Start();
            Task<string> t2 = new Task<string>(GetX);
   
            Console.ReadKey();
        }

        public static void Show() {
            Console.WriteLine(x);
        }
        public static string GetX() {
            for (int i = 0; i < 10; i++)
            {
                x += "x";
                Thread.Sleep(20);
            }
            return x;
        }
    }
}

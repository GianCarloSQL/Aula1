using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            List<int> lista = ProgramVar.executar(999999);
            stopwatch.Stop();
            Console.WriteLine($"Tempo passado: {stopwatch.Elapsed}");
            Console.ReadKey();
            */

            // string[] array = { "gian", "Felipe", "Euclides"};
            try
            {
                var testeTemplate = @"Nome do usuario:{0} 
Idade:{1}
Descricao:{2}";
                var usuario = string.Format(testeTemplate
                    , Console.ReadLine()
                    , Console.ReadLine()
                    , Console.ReadLine());
                
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
            /*
           Console.WriteLine("Informe o livro a ser consultado: ");
           var numeroLivro = Console.ReadLine();
            if (numeroLivro == "123456")
            {
                Console.WriteLine("Livro indisponivel");
            }
            else {
                Console.WriteLine("Deseja alocar o livro? (1-sim, 2-nao)");
                var resposta = Console.ReadLine();
                if (resposta == "1")
                {
                    Console.WriteLine("livro Alocado");
                }

            }*/
        }



    }
}

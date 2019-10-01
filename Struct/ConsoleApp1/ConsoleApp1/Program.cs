using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static void Main(string[] args)
       {
            Aula04 a = new Aula04();
            Console.Write(a.GetImagem());
            Thread.Sleep(100000);
            //Aula04.Exercicio07semArray();
            //  game();
            /*
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                List<int> lista = ProgramVar.executar(999999);
                stopwatch.Stop();
                Console.WriteLine($"Tempo passado: {stopwatch.Elapsed}");
                lista.Sort();
                for (int i =0; i< lista.Count; i++) {
                    Console.WriteLine(lista[i]);
                }
                Console.ReadKey();
                */

            /*

            String Concat

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
            */


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

        public static void cairBoneco() {
            string c = "(+ -)";
            string b = "\n  |";
            string p = "\n / \\ ";
            bool aux = true;
            while (true)
            {
                Console.Write(c + b + b + p);
                if (aux) {
                    Console.ReadKey();
                    aux = false;
                }
               
                Thread.Sleep(100);
                Console.Clear();
                if (true)
                {
                    c = "\n" + c;
                    b = "\n" + (b.Substring(1, b.Length - 1));
                    p = "\n" + (p.Substring(1, p.Length - 1));
                }
            
                Thread.Sleep(100);
              
            }
        }


        public static void normalBoneco()
        {
            string c = "(+ -)";
            string b = "  |";
            string mao = " /|\\";
            string p =  " / \\ ";
            string p2 = "  \\ \\";
            bool anda = false;
            while (true)
            {
               
                if (!anda)
                {

                    Console.WriteLine(c);
                    Console.WriteLine(b);
                    Console.WriteLine(mao);
                    Console.WriteLine(b);
                    Console.WriteLine(p);
                    anda = true;
                }
                else {
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                    Console.WriteLine(mao);
                    Console.WriteLine(b);
                    Console.WriteLine(p2);
                    anda = false;
                }
                Thread.Sleep(5);
                Console.Clear();

                c = " " + c;
                b = " " + b;
                p = " " + p;
                mao = " " + mao;
                p2 = " " + p2;
                Thread.Sleep(5);


            }
          
        }

        public static void cairBuracoNegro()
        {
            string c = "(+ -)";
            string b = "\n  |";
            string p = "\n / \\ ";
            bool aux = true;
            int t = 0;
            while (true)
            {
                Console.Write(c + b + b + p);
                if (aux)
                {
                    Console.ReadKey();
                    aux = false;
                }

                Thread.Sleep(200);
                t++;
                Console.Clear();
                if (t > 6)
                {
                    c = "\n" + c;
                    b = "\n" + b;
                    p = "\n" + p;
                }
                else {
                    c = "\n" + c;
                    b = "\n" + (b.Substring(1, b.Length - 1));
                    p = "\n" + (p.Substring(1, p.Length - 1));
                }
                
                Thread.Sleep(200);

            }
        }

        public static void game() {
            
            Thread t = new Thread(run);
            
            Thread t2 = new Thread(run2);
            t.Start();
            t2.Start();

            while (true) {
                Console.WriteLine(p1);
                Console.WriteLine(p2);
                Thread.Sleep(10);

                Console.Clear();
                Thread.Sleep(10);
                if (p1.Length == 40) {
                    Console.Clear();
                    p2 = null;
                    Console.WriteLine("Player 1 wins");

                    break;
                }else
                if (p2.Length == 40) {
                    Console.Clear();
                    p1 = null;
                    Console.WriteLine("Player 2 wins");
                  
                    break;
                }

            }
            t = null;

            Thread.Sleep(100000);

        }
        static void run() {
            while (true)
            {
                string  v = Console.ReadKey().KeyChar.ToString();
                if (v == "d") {
                    p1 = " " + p1;

                } else if (v=="6") {
                    p1 = "          P1";
                }
            }
        }

        static void run2()
        {
            while (true)
            {
                string v = Console.ReadKey().KeyChar.ToString();
                if (v == "5")
                {
                    p2 = " " + p2;
                }
                
            }
        }
        static string p1 = "P1";
        static  string p2 = "P2";

        private static void Arvore(int nivel)
        {
            for (int linha = 1; linha <= nivel; linha++)
            {
                for (int coluna = 1; coluna <= linha; coluna++)
                {
                    Console.Write ("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("||");
            Console.WriteLine("||");
            Console.WriteLine("||");
            Console.WriteLine("||");
            Console.WriteLine("||");
        }

    }
    
}

using System;
using System.Collections.Generic;
using DataFrame;

namespace Studing
{
    class Program
    {
        static void Main(string[] args)
        {
            Map<Pessoa> mapa = new Map<Pessoa>("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            mapa.Testar();
            Console.WriteLine("Succefull");
            Console.ReadKey(true);
        }









        public static void mainn() {
            List<int> n = new List<int>() { 0, 1, 2, 3, 4, 5, 6 };
            Pessoa p = n[5];
            Pessoa p2 = new Pessoa() { A = 5 };
            p = p2;
            p = 1;
            p2 = new Pessoa().A = p.A;
            p = p2 + p;
            if (p.Verify())
            {
                Console.WriteLine(p.A);
            }
            Console.ReadLine();
        }
        public class Pessoa
        {
            public int A { get; set; }
            public string Nome { get; set; }

            public static implicit operator Pessoa(int v)
            {
                return new Pessoa() { A = v };
            }

            public static Pessoa operator +(Pessoa p, Pessoa p2)
            {
                p.A += p2.A;
                return p;
            }
        }


    }
}

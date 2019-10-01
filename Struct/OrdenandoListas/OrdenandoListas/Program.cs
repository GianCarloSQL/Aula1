using System;
using System.Collections.Generic;
using System.Linq;

namespace OrdenandoListas
{
    class Program
    {
        static List<Pessoa> pessoas = new List<Pessoa>();
        static void Main(string[] args)
        {
            #region Main
            /*
            var cesta = new List<Fruta>();
            cesta.Add(new Fruta("Tomate", "vermelho", 212));
            cesta.Add(new Fruta("Goiaba", "vermelho", 150));
            cesta.Add(new Fruta("Abacaxi", "amarelo", 300));
            cesta.Add(new Fruta("Manga", "amarelo", 80));
            cesta = cesta.Where(x => x.Peso > 200).ToList();
            cesta.ForEach(x => Console.WriteLine($"ID: {x.ID} Nome: {x.Name} Peso {x.Peso}"));
            (from fruta in cesta where fruta.Name == "Tomate" select fruta).ToList().ForEach(x => Console.WriteLine($"Fruta: {x.Name}"));
            (from x in cesta where x.Cor == "vermelho" && x.Peso > 200 select x).ToList().ForEach(x => Console.WriteLine($"Fruta: {x.Name}"));
            Console.ReadKey();
            */
            #endregion

            CriaLista();
            questao3();
            Console.ReadKey();
        }

        public static void questao1()
        {
            Console.WriteLine("Listar estas informações em ordem crescente Pelo nome e decrescente  Pela data de nascimento");
            pessoas.OrderByDescending(x => x.DataNascimento).ToList().ForEach(x => Console.WriteLine(x.ToString()));
            Console.WriteLine("-------------------------------------------------------------");
            pessoas.OrderBy(x => x.Nome).ToList().ForEach(x => Console.WriteLine(x.ToString()));
        }
        public static void questao2()
        {
            Console.WriteLine("Listar as pessoas que contem mais de 500 reais na carteira ");
            pessoas.Where(x => x.Carteira >= 500).ToList().ForEach(x => Console.WriteLine(x.ToString()));
        }

        public static void questao3()
        {
            Console.WriteLine("Listar as pessoas com mais de 18 anos - Bônus");
            pessoas.Where(x => (2019 - x.DataNascimento.Year) > 18).ToList().ForEach(x => Console.WriteLine(x.ToString()));
        }

        public static void questao4()
        {
            Console.WriteLine("Listar as pessoas com menos de 16 anos - Bônus");
            pessoas.Where(x => (2019 - x.DataNascimento.Year) <= 16).ToList().ForEach(x => Console.WriteLine(x.ToString()));
        }


        /// <summary>
        /// string format
        /// </summary>
        public static void Mostrar()
        {
            string template = "ID: {0:3}  Nome: {1:10}";
            string text = string.Format(template, pessoas[1].ID, pessoas[1].Nome);
            Console.WriteLine(text);
        }

        public static void CriaLista()
        {
            //   pessoas.Add(new Pessoa(1, "Spears", DateTime.Parse( "07/11/2004"), 846.96));
            string bancoDeDados = @"
1,Spears,07/11/2004,846.96;
2,Swanson,20/06/2003,233.09;
3,Gay,03/12/2001,911.92;
4,Gregory,02/01/2000,469.01;
5,Olson,18/07/2001,261.90;
6,Garza,01/04/2000,360.41;
7,Sweet,12/03/2003,312.76;
8,Cline,26/03/2002,484.51;
9,Oliver,05/07/2004,513.76;
10,Vang,10/07/2000,271.05;
11,Maddox,29/05/2004,783.97;
12,Garrett,03/06/2006,154.11;
13,Mcintosh,06/07/2006,902.80;
14,Yang,29/04/2005,550.48;
15,Hendricks,05/09/2003,410.56;
16,Cain,12/01/2002,221.13;
17,Blackburn,10/05/2000,135.67;
18,Howe,27/09/2005,360.14;
19,Pratt,18/09/2000,991.83;
20,Sherman,20/02/2003,667.00";
            var aux = bancoDeDados.Split(';');
            foreach (var item in aux)
            {
                var pessoa = item.Split(',');
                Pessoa p = new Pessoa(int.Parse(pessoa[0]), pessoa[1], DateTime.Parse(pessoa[2]), double.Parse(pessoa[3]));
                pessoas.Add(p);
            }
        }

        public List<Pessoa> GetPessoasOrdenadas() {
            return pessoas.OrderBy(i => i.Nome).ToList();
        }


    }
}

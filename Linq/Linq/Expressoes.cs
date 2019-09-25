using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Expressoes
    {

        public static void Exp(){
            int? c = null;
            // d = c, if c is not null, d = -1 if c is null.
            int d = c ?? 0;
            Console.WriteLine($"d is {d}");
        }

        public static void SomaCriancas()
        {
            List<Crianca> criancas = new List<Crianca>() {
                new Crianca("Gian",10),
                new Crianca ("Henrique",20),
                new Crianca ("Luiz Otavio",15)
            };
            Console.WriteLine(criancas.Sum(x => x.Balas));
        }
        public static void PopulaVendas()
        {
            List<Venda> vendas = new List<Venda>() {
                new Venda("XIOMI",3, 1000.0),
                new Venda("Iphone Fogao 4 bocas",4, 11000.0),
                new Venda("Samsung",2, 3000.0)
            };
            // average
            Console.WriteLine(vendas.Average(venda => venda.Qtd * venda.Valor));

        }
        public static void Agregar()
        {
            List<string> nomes = new List<string>() {
                "Gian","Pedro","Barbara","Joao","Eusebio"
            };
            List<string> texto = nomes.Aggregate((nome1, nome2) => nome1 + ";" + nome2).Split(';').ToList();
            texto.ForEach(x => Console.WriteLine(x));
        }
    }
}


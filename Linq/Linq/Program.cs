using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static List<Carro> carros = new List<Carro>();
        static void Main(string[] args)
        {
            PopulaLista();
            Console.WriteLine("Menu Sistema");
            while (true)
            {
                Console.WriteLine("1 - Mostrar Base de Dados");
                Console.WriteLine("2 - Gerar Relatorio");
                var aux = Console.ReadLine();
                switch (aux)
                {
                    case "1":
                        Console.WriteLine("Id               Carro                                    Valor          Quantidade       Data");
                        mostrarDados(carros);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Informe  o mes:");
                        var mes = Console.ReadLine();
                        Console.WriteLine("Id               Carro                                    Valor          Quantidade       Data");
                        mostrarDados(GetRelatorioMes(int.Parse(mes)));
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }

        }

        private static List<Carro> GetRelatorioMes(int mes)
        {
            List<Carro> aux = new List<Carro>();
            foreach (var item in carros)
            {
                if (item.Data.Month == mes)
                {
                    aux.Add(item);
                }
            }
            return aux;
        }

        public static void PopulaLista()
        {
            string line = "";
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\900092\Desktop\BancoDeDados.txt");
            while ((line = file.ReadLine()) != null)
            {
                line = line.Replace(",", ".");

                string[] aux = line.Split(';');
                aux[3].Replace(" ", "");
                Carro c = new Carro(int.Parse(aux[0]), aux[1], double.Parse(aux[2]), int.Parse(aux[3]), DateTime.Parse(aux[4]));
                carros.Add(c);
            }
        }

        public static void mostrarDados(List<Carro> lista)
        {
            string template = "{0,-3}           {1,-35}         {2,-5}           {3,-3}          {4,-10}";
            lista.ForEach(c => Console.WriteLine(string.Format(template, c.ID, c.Marca, c.Valor, c.Quantidade, c.Data.ToShortDateString())));
            // carros.ForEach(c => Console.WriteLine($"ID: {c.ID}  Marca: {c.Marca}    Valor: {c.Valor}    Quantidade: {c.Quantidade}  Data: {c.Data}"));
        }
    }
}

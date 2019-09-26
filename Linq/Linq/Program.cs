using System;
using System.Collections.Generic;
using System.IO;
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
                Console.Clear();
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
                        List<Carro> c = GetRelatorioMes(int.Parse(mes));
                        mostrarDados(c);
                        Console.WriteLine($"A Soma total das vendas foi: {c.Sum(x => x.Valor * x.Quantidade).ToString("N")} e a media deste periodo foi: {c.Average(x => (x.Quantidade * x.Valor) / x.Quantidade).ToString("N")}");
                        Console.WriteLine("Deseja exportar o relatorio? (sim,nao)");
                        if (Console.ReadLine().Equals("sim"))
                        {
                            Console.WriteLine("Deseja exportar em excell(1) ou txt(2)?");
                            var a = int.Parse(Console.ReadLine());
                            ExportarRelatorio(c, a==1? true : false);
                        }
                        Console.WriteLine("Relatorio salvo com sucesso!");
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
            aux = carros.Where(carro => carro.Data.Month.Equals(mes)).ToList();
            return aux;
        }

        public static void PopulaLista()
        {
            string line = "";
            StreamReader file = new StreamReader(@"C:\Users\900092\Desktop\BancoDeDados.txt");
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
            lista.ForEach(c => Console.WriteLine(string.Format(template, c.ID, c.Marca, c.Valor.ToString("N"), c.Quantidade, c.Data.ToShortDateString())));
            // carros.ForEach(c => Console.WriteLine($"ID: {c.ID}  Marca: {c.Marca}    Valor: {c.Valor}    Quantidade: {c.Quantidade}  Data: {c.Data}"));
        }



        public static void ExportarRelatorio(List<Carro> c, bool csv)
        {
            string formato = csv ? "csv" : "txt";
            Console.WriteLine("Informe o nome do arquivo a salvar: ");
            StreamWriter salvar = new StreamWriter($"C:\\Users\\900092\\Desktop\\{Console.ReadLine()}.{formato}");
            string template = "{0,0};{1,0};{2,0};{3,0};{4,0}";
            string aux = "Id;Carro;Valor;Quantidade;Data\n";
            c.ForEach(i => aux += string.Format(template, i.ID, i.Marca, i.Valor.ToString("N"), i.Quantidade, i.Data.ToShortDateString()) + "\n");
            salvar.WriteLine(aux);
            salvar.Close();
        }
    }
}

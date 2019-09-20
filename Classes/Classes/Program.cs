using Classes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            //Polimorfismo 
            /*
            Pessoa p;
            p = new PessoaFisica();
            Console.WriteLine(p.GetImposto(10));
            p = new PessoaJuridica();
            Console.WriteLine(p.GetImposto(10));
            */

         //   ExercicioCarro();
           

            Console.ReadKey();
        }

        public static void ExercicioCarro()
        {
            List<Carro> lista = new List<Carro>();
            Console.WriteLine("Sistema de Carros");
            while (true)
            {
                Console.WriteLine("Para cadastrar informe a marca do veiculo (insira 1 para sair)");
                var marca = Console.ReadLine();
                if (marca.Equals("1"))
                {
                    break;
                }
                Console.WriteLine("Informe o modelo: ");
                var modelo = Console.ReadLine();
                Console.WriteLine("Informe o Ano: ");
                var ano = Console.ReadLine();
                Console.WriteLine("Informe o valor: ");
                var valor = Console.ReadLine();
                var placa = "";
                  while (ListaBranca.ValidaPlaca(placa))
                {
                    Console.WriteLine("Informe a placa: ");
                    placa = Console.ReadLine();

                }
                Carro c = new Carro(marca, modelo, int.Parse(ano), double.Parse(valor), placa);
                lista.Add(c);
            }
            Console.Clear();
            Console.WriteLine("Carros Cadastrados: ");
            lista.ForEach(i => Console.WriteLine(i.ToString() + "\n-----------------------------"));
        }

        public static void popula()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                int n = new Random().Next(100);
                if (!list.Contains(n))
                {
                    list.Add(n);
                    continue;
                }
                i--;
            }
            //delegate, anonimous method
            List<int> listaNova = list.Where(i => i%2==0).ToList();
           
        }

    }
}

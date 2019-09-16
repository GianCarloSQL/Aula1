using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Semana02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] aux = BuscaAutomovel("nome:Jetta,marca:Volkswagen,ano:2014,cambio:automatico,descricao:Porta direita nao abre;nome:Gol,marca:Volkswagen,ano:2015,cambio:manual,descricao:Faz barulho estranho;nome:Corolla,marca:Toyota,ano:2019,cambio:automatico,descricao:Carro de tiozao;nome:Mustang,marca:Ford,ano:2010,cambio:automatico,descricao:Voce nao pode pagar", Console.ReadLine());
            for (int i = 0; i < aux.Length; i++)
            {
                Console.WriteLine(aux[i]);
            }
            */

            //    BuscaAutomovel("nome:Jetta,marca:Volkswagen,ano:2014,cambio:automatico,descricao:Porta direita nao abre;nome:Gol,marca:Volkswagen,ano:2015,cambio:manual,descricao:Faz barulho estranho;nome:Corolla,marca:Toyota,ano:2019,cambio:automatico,descricao:Carro de tiozao;nome:Mustang,marca:Ford,ano:2010,cambio:automatico,descricao:Voce nao pode pagar");

            Console.WriteLine(" As pessoas que contem mais de 18 anos são:" + procuraPessoa("nome: Felipe, idade: 27; nome: Giomar,idade: 17; nome: Edson,Idade: 19; nome: Ericledson,idade: 75; nome: Junior,idade: 45"));
            Thread.Sleep(10000);
        }

        private static string procuraPessoa(string BandoDeDados)
        {
            string retorno = "";
            var aux = BandoDeDados.Split(';');
            foreach (var item in aux)
            {
                var split = item.Split(',');
                for (int i = 0; i < 2; i++)
                {
                    split[i] = split[i].Split(':')[1];
                }
                if (int.Parse(split[1]) >= 18)
                {
                    retorno += "\n" + split[0];
                }
            }
            return retorno;
        }




        private static void BuscaAutomovel(string bandoDeDados)
        {
            var aux = bandoDeDados.Split(';');
            while (true)
            {
                Console.WriteLine("Informe o nome do veiculo: (1 - Sair)");
                var veiculoBusca = Console.ReadLine();
                if (veiculoBusca == "1")
                    break;
                foreach (var item in aux)
                {
                    var split = item.Split(',');
                    for (int i = 0; i < 5; i++)
                    {
                        split[i] = split[i].Split(':')[1];
                    }
                    //split[0] = nome
                    //split[1] = marca
                    //split[2] = ano
                    //split[3] = cambio
                    //split[4] = descricao
                    if (split[0] == veiculoBusca)
                    {
                        Console.WriteLine(string.Format("Nome Veiculo: {0}\nMarca: {1}\nAno: {2}\nCambio: {3}\nDescricao: {4}", split));
                        // Console.WriteLine($"Nome Veiculo: {split[0]}\nMarca: {split[1]}\nAno: {split[2]}\nCambio: {split[3]}\nDescricao: {split[4]}");
                    }
                }
            }
        }

        private static string[] BuscaAutomovel(string bandoDeDados, string veiculoBusca)
        {
            var aux = bandoDeDados.Split(';');

            foreach (var item in aux)
            {
                var split = item.Split(',');
                for (int i = 0; i < 5; i++)
                {
                    split[i] = split[i].Split(':')[1];
                }

                if (split[0] == veiculoBusca)
                {
                    return split;
                }

            }
            return null;
        }



        public static string ForSplit()
        {
            var texto = @"Aqui; temos; um; texto; que; iremos; mudar; para; uma; coleção e; vamos; colocar; isto; {seunome}; para; depois; usar; com; o; replace";
            return texto.Replace("{seunome}", "Gian Carlo").Replace("; ", " ");
        }

        public static void Lista(string conteudo)
        {
            var aux = conteudo.Split(';');
            Console.WriteLine("Informe o nome: ");
            var nomeBusca = Console.ReadLine();
            foreach (var item in aux)
            {
                var split = item.Split(',');
                for (int i = 0; i < 2; i++)
                {
                    split[i] = split[i].Split(':')[1];
                }
                //deprecated
                /*var nome = split[0].Split(':')[1];
                  var idade = split[1].Split(':')[1];
                  var aux = split[2].Split(":"[1]);  */
                if (split[0] == nomeBusca)
                {
                    Console.WriteLine($"O {split[0]} esta com {split[1]} anos de idade.");
                }
            }
        }






        public static void Show()
        {
            Console.WriteLine("Texto:");
            var conteudo = Console.ReadLine();

            foreach (var item in conteudo)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine($"{item} é par");
                }
                else
                {
                    Console.WriteLine(item);
                }

            }

            Console.ReadKey();
        }



    }
}

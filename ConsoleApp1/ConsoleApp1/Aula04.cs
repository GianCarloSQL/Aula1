using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Aula04
    {

        public static void PedeInformacao()
        {

            while (true)
            {
                Console.WriteLine("Digite a sua idade: ");
                int idade = int.Parse(Console.ReadLine());
                if (ValidaIdade(idade))
                {
                    break;
                }
                if (idade >= 18)
                {
                    Console.WriteLine("Voce pode beber bebidas alcoolicas");
                }
                else
                {
                    Console.WriteLine("Voce nao pode beber bebidas alcoolicas");
                }



            }


        }
        public static bool ValidaIdade(int idade)
        {
            return (idade >= 99 || idade < 0) ? true : false;
        }


        public static void Exercicio07()
        {
            Console.WriteLine("Informe o texto: ");
            string texto = Console.ReadLine();
            char[] aux = texto.ToCharArray();
            int countA = 0;
            int countE = 0;
            int countI = 0;
            int countO = 0;
            int countU = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                char c = aux[i];
                switch (c)
                {
                    case 'a':
                        countA++;
                        break;
                    case 'e':
                        countE++;
                        break;
                    case 'i':
                        countI++;
                        break;
                    case 'o':
                        countO++;
                        break;
                    case 'u':
                        countU++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"a: {countA}\ne: {countE}\ni: {countI}\no: {countO}\nu: {countU}\n");
            Console.ReadKey();
        }


    }
}


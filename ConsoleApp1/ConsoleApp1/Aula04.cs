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

        public void PedeInformacao()
        {

            while(true)
            {
                Console.WriteLine("Digite a sua idade: ");
                int idade = int.Parse(Console.ReadLine());
                if (idade >= 99) {
                    break;
                }
                if (idade >= 18)
                {
                    Console.WriteLine("Voce pode beber bebidas alcoolicas");
                }
                else {
                    Console.WriteLine("Voce nao pode beber bebidas alcoolicas");
                }

            } 

         
        }




    }
}


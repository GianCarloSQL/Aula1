using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProgramVar
    {

        public static List<int> executar(int tamanho)
        {
            bool aux = true;
            List<int> primos = new List<int>();
            for (int j = tamanho; j > 2; j--)
            {
                for (int i = 2; i <= j - 1; i++)
                {
                    if (j % i == 0)
                    {
                        aux = false;
                        break;
                    }

                }
                if (aux)
                {
                    primos.Add(j);

                }
                aux = true;
            }

            return primos;

        }


    }
}

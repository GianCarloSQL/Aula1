using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int? idade = null;
                int b = idade ?? 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

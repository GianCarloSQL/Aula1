using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Model
{
    class PessoaJuridica : Pessoa
    {
        public override double GetImposto(double valor)
        {
            return valor * 4;
        }
    }
}

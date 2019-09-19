using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Model;
namespace Classes.Model
{
    class PessoaFisica : Pessoa
    {
        
        public override double GetImposto(double valor)
        {
            return valor * 2;
        }
    }
}

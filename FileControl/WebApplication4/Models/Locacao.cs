using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoTech.Model
{
    public class Locacao : ModelControl
    {
        public double Valor { get; set; }
        public Colaborador Colaborador { get; set; }
        public Veiculo Veiculo { get; set; }
        
    }
}

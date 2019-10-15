using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoTech.Model
{
    public class Veiculo: ModelControl
    {
        public int Codigo { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public TipoVeiculo Tipo { get; set; }
        public Cor Cor { get; set; }
        public Marca Marca { get; set; }
        public Colaborador Colaborador { get; set; }
    }
}

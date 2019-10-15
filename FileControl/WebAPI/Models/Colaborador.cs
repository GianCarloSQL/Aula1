using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoTech.Model
{
    public class Colaborador : ModelControl
    {
        public int Codigo { get; set; }
        public string Email { get; set; }
        public int Is_PCD { get; set; }
        public bool ForneceCarona { get; set; }
        public bool ResideBlumenau { get; set; }
        public bool Trabalho_Noturno { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public List<Veiculo> Veiculos { get; set; }
        public List<Locacao> Locacoes { get; set; }
        public Status Status { get; set; }
    }
}

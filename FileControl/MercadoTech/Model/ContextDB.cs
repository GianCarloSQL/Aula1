using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoTech.Model
{
    public class ContextDB
    {
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Locacao> Locacao { get; set; }
    }
}

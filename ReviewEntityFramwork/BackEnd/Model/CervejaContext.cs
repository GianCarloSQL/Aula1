using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Model
{
    public class CervejaContext : DbContext
    {
        public DbSet<Cerveja> Cervejas { get; set; }
    }
}

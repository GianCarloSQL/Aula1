using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BicicletaLibrary.Model;
namespace BicicletaLibrary.Model
{
    public class Context : DbContext
    {
        public DbSet<Bicicleta> Bicicletas { get; set; }
    }
}

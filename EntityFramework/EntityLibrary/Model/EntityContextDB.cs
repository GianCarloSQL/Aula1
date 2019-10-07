using System;
using System.Collections;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary.Model
{
    public class EntityContextDB : DbContext
    {
        public DbSet<Pessoa> Lista_Pessoas { get; set; }
    }
}

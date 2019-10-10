using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryFlower.Model;
namespace LibraryFlower.Model
{
    public class Context : DbContext
    {
        public DbSet<Flor> Flores { get; set; }
    }
}

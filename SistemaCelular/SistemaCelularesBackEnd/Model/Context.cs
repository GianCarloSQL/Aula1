using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularLibrary.Model
{
    public class Context : DbContext
    {
        private static Context Singleton = new Context();
        public static Context GetInstance()
        {
            return Singleton;
        }
        private Context() { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Celular> Celulares { get; set; }
    }
}

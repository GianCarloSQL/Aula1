using Locacao.Controller;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locacao.Model
{
    public class LocacaoContext : DbContext
    {

        public DbSet<Livro> livros { get; set; }
        public DbSet<Usuario> usuarios { get; set; }

        private static LocacaoContext Singleton = new LocacaoContext();
        public static LocacaoContext GetInstance()
        {
            return Singleton;
        }
        private LocacaoContext() { }
    }

}

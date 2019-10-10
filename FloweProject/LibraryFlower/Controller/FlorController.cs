using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryFlower.Model;
namespace LibraryFlower.Controller
{
    public class FlorController
    {
        public Context Context = new Context();

        public IQueryable<Flor> GetCervejas()
        {
            return Context.Flores;
        }
        public void AddFlor(Flor c)
        {
            Context.Flores.Add(c);
            Context.SaveChanges();
        }
    }
}

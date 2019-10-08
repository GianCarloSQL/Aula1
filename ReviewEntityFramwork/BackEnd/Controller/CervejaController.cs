using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Model;
namespace BackEnd.Controller
{
    public class CervejaController
    {
        public CervejaContext Context = new CervejaContext();

        public IQueryable<Cerveja> GetCervejas()
        {
            return Context.Cervejas;
        }
        public void AddCerveja(Cerveja c)
        {
            Context.Cervejas.Add(c);
            Context.SaveChanges();
        }
    }
}

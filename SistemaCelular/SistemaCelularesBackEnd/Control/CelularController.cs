using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CelularLibrary.Model;

namespace CelularLibrary.Control
{
    public class CelularController
    {
        public Context Context = Context.GetInstance();

        public IQueryable<Celular> GetCelulares()
        {
            return Context.Celulares.Where(c => c.Ativo);
        }

        public bool AtualizarCelular(Celular c)
        {
            Celular celBusca = Context.Celulares.FirstOrDefault(x => x.Id == c.Id);
            if (celBusca == null)
                return false;
            else
                c.Update();
            c = celBusca;
            Context.SaveChanges();
            return true;
        }
        public bool InserirCelular(Celular c)
        {
            if (string.IsNullOrWhiteSpace(c.Marca))
            {
                return false;
            }
            Context.Celulares.Add(c);
            Context.SaveChanges();
            return true;
        }
        public bool DeletaCelular(int id)
        {
            var celular = Context.Celulares.FirstOrDefault(x => x.Id == id);
            return (celular != null) ? !celular.Ativo ? (celular.Ativo = false) : false : false;

        }
    }
}

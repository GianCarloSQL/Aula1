using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CelularLibrary.Model;
namespace CelularLibrary.Control
{
    public abstract class AbstractController<T>
    {
        public Context Context = Context.GetInstance();
        public abstract bool Inserir(T info);
        public abstract bool Atualiza(T info);
        public abstract bool Deleta(T info);
        /*
        public IQueryable<T> GetLista<T>()
        {
            if (typeof(T) == new Celular().GetType()) {
              //  return Context.Celulares.Where(c => c.Ativo);
            }
          //  return Context.Celulares.Where(c => c.Ativo);
            // return Context.Celulares.Where(c => c.Ativo);
        }
        */
    }
}

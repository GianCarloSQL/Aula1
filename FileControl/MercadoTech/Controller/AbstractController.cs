using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoTech.Model;
namespace MercadoTech.Controller
{
    public abstract class AbstractController<T>
    {
        public Context Context = Context.GetInstance();
        public abstract bool Inserir(T info);
        public abstract bool Atualiza(T info);
        public abstract bool Deleta(T info);
        public abstract IQueryable<T> GetLista();
        public void Save()
        {
            Context.SaveChanges();
        }

    }
}

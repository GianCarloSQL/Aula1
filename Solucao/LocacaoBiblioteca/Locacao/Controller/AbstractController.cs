using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locacao.Model;
namespace Locacao.Controller
{
   public abstract  class AbstractController<T>
    {
        public LocacaoContext Context = LocacaoContext.GetInstance();
        public abstract bool Inserir(T info);
        public abstract bool Atualiza(T info);
        public abstract bool Deleta(T info);

        public abstract IQueryable<T> GetLista();
        // implementar
        public void Save()
        {
            Context.SaveChanges();
        }
    }
}

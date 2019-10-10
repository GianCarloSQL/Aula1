using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locacao.Controller;
using BicicletaLibrary.Model;
namespace BicicletaLibrary.Controller
{
    public class BicicletaController : AbstractController<Bicicleta>
    {
          Context Context = new Context();
        public override bool Atualiza(Bicicleta info)
        {
            throw new NotImplementedException();
        }

        public override bool Deleta(Bicicleta info)
        {
            if (info == null)
            {
                return false;
            }
            info.Ativo = false;
            Save();
            return true;
        }

        public override IQueryable<Bicicleta> GetLista()
        {
            return Context.Bicicletas.Where(b => b.Ativo);
        }

        public override bool Inserir(Bicicleta info)
        {
            if (info == null)
                return false;
            Context.Bicicletas.Add(info);
            Context.SaveChanges();
            return true;
        }
    }
}

using CelularLibrary.Control;
using CelularLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCelularesBackEnd.Control
{

    public class CelController : AbstractController<Celular>
    {
        public override bool Atualiza(Celular info)
        {
            info.Update();
            Save();
            return true;
        }

        public override bool Deleta(Celular info)
        {
            var celular = Context.Celulares.FirstOrDefault(x => x.Id == info.Id);
            if (celular == null)
            {
                return false;
            }
            celular.Ativo = false;
            Save();
            return true;
        }
        public override bool Inserir(Celular info)
        {
            if (string.IsNullOrWhiteSpace(info.Marca))
            {
                return false;
            }
            Context.Celulares.Add(info);
            Save();
            return true;
        }

        public override IQueryable<Celular> GetLista()
        {
            return Context.Celulares.Where(x => x.Ativo);
        }
    }
}

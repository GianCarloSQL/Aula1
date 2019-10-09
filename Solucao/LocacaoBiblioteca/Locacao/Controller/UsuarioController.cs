using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locacao.Model;

namespace Locacao.Controller
{
    public class UsuarioController : AbstractController<Usuario>
    {
        public override bool Atualiza(Usuario info)
        {
            if (info == null)
                return false;
            info.Update();
            Save();
            return true;
        }

        public override bool Deleta(Usuario info)
        {
            if (info == null)
            {
                return false;
            }
            info.Ativo = false;
            Save();
            return true;
        }

        public override bool Inserir(Usuario info)
        {

            if (string.IsNullOrWhiteSpace(info.Login))
            {
                return false;
            }
            Context.usuarios.Add(info);
            Save();
            return true;
        }
        public override IQueryable<Usuario> GetLista()
        {
            return Context.usuarios.Where(x => x.Ativo);
        }
    }
}

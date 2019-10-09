using Locacao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locacao.Controller
{
    public class LivroController : AbstractController<Livro>
    {
        public override bool Atualiza(Livro info)
        {
            if (info == null)
                return false;
            info.Update();
            Save();
            return true;
        }

        public override bool Deleta(Livro info)
        {
            if (info == null)
            {
                return false;
            }
            info.Ativo = false;
            Save();
            return true;
        }

        public override bool Inserir(Livro info)
        {

            if (string.IsNullOrWhiteSpace(info.Titulo))
            {
                return false;
            }
            Context.livros.Add(info);
            Save();
            return true;
        }
        public override IQueryable<Livro> GetLista()
        {
            return Context.livros.Where(x => x.Ativo);
        }


    }
}

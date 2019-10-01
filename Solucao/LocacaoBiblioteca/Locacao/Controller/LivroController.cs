using Locacao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locacao.Controller
{
    public class LivroController
    {
        //public List<Livro> livros;
         LocacaoContext db = new LocacaoContext();

        public LivroController()
        {
       
        }

        public void AdicionaLivro(Livro livro)
        {
            livro.CodLivro = LocacaoContext.indiceLivros;
            db.livros.Add(livro);
            LocacaoContext.indiceLivros++;
        }
        public List<Livro> GetLivros()
        {
            return db.livros;
        }

        public void RemoveLivro(Livro l)
        {
            db.livros.Remove(l);
        }
    }
}

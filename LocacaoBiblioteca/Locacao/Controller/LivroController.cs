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
        static int cod = 3;
       private  List<Livro> livros = new List<Livro>() {
            new Livro(0,"the bomberman", true),
            new Livro(1,"the fisherman", true),
            new Livro(2,"the joker master", true),
        };


        public LivroController(){
           
        }

        public void AdicionaLivro(Livro livro) {
            livro.Disponivel = true;
            livro.CodLivro = cod;
            cod++;
            livros.Add(livro);
        }
        public List<Livro> GetLivros() {
            return livros;
        }

        public void RemoveLivro(Livro l) {
            livros.Remove(l);
        }
    }
}

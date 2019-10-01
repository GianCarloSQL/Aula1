using Locacao.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locacao.Model
{
    public class LocacaoContext
    {
        public LocacaoContext()
        {

        }

        public List<Livro> livros = new List<Livro>() { new Livro(0, "Stars"), new Livro(1, "Wars"), new Livro(2, "Hp") };
        public List<Usuario> usuarios = new List<Usuario>() { new Usuario(0, "Gian", "1234"), new Usuario(1, "Vilson", "1234"), new Usuario(2, "Pedro", "1234") };

        public static int indiceLivros { get; set; } = 3;
        public static int indiceUsuarios { get; set; } = 3;

    }

}

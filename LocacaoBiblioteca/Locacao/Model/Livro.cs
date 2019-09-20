using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locacao.Model
{
    public class Livro
    {
        public Livro(int Codigo, string Titulo, bool Disponivel)
        {
            this.CodLivro = CodLivro;
            this.Disponivel = Disponivel;
            this.Titulo = Titulo;
        }
        public Livro() {
        }

        public int CodLivro { get; set; }
        public string Titulo { get; set; }
        public bool Disponivel { get; set; }

        
          public override string ToString()
        {
            return $"Titulo: {Titulo}\nCodigo: {CodLivro}\nDisponibilidade: {Disponivel}";
        }
    }
}

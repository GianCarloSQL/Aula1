using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locacao.Model
{
    public class Livro : AbstractModel
    {
        public Livro(int cod, string Titulo)
        {
            this.CodLivro = cod;
            this.Titulo = Titulo;
        }
        public Livro() { }

        [Required]
        public int CodLivro { get; set; }

        [Required]
        public string Titulo { get; set; }
        public bool Disponivel { get; set; } = true;

        public override string ToString()
        {
            string template = "{0,-5}       {1,-5}        {2,-30}        {3,-5}";
            return string.Format(template,Id, CodLivro, Titulo,Disponivel);
        }

        public override void Update()
        {
            DataAlteracao = DateTime.Now;
        }
    }
}

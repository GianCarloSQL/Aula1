using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locacao.Model
{
    public class Usuario : AbstractModel
    {
        public Usuario() { }

        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
            livros = new List<Livro>();
        }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Senha { get; set; }

        public List<Livro> livros { get; set; }

        public override void Update()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            string template = "{0,-15}        {1,-15}";
            return string.Format(template,Login,Senha);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locacao.Model
{
  public   class Usuario
    {
        public Usuario(int cod,string login, string senha) {
            Id = cod;
            Login = login;
            Senha = senha;
            livros = new List<Livro>();
        }

        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
            livros = new List<Livro>();
        }
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativo{ get; set; }
        public int UsuarioCriacao { get; set; }
        public  DateTime DataCriacao{ get; set; }
        public DateTime DataAlteracao { get; set; }
        public List<Livro> livros { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locacao.Model
{
  public   class Usuario
    {
        public Usuario(string login, string senha) {
            Login = login;
            Senha = senha;
        }
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativo{ get; set; }
        public int UsuarioCriacao { get; set; }
        public  DateTime DataCriacao{ get; set; }
        public DateTime DataAlteracao { get; set; }

    }
}

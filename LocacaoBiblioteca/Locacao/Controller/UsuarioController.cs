using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locacao.Model;

namespace Locacao.Controller
{


    /// <summary>
    /// Classes que contem os metodos de usuario e senha
    /// </summary>
    public class UsuarioController
    {
        static int i = 2;
        private List<Usuario> usuarios = new List<Usuario>() {
            new Usuario(0,"Gian", "1234"),
            new Usuario(1,"Pedro", "5522")
        };

        /* public bool LoginSistema(Usuario u)
         {
             return (u.Login == "admin") && (u.Senha == "admin");
         }
 */
        public List<Usuario> GetUsuarios() {
            return usuarios;
        }
        public void AdicionaUsuario(Usuario u) {
            u.Id = i;
            i++;
            usuarios.Add(u);
        }
        public void RemoveUsuario(Usuario u) {
            usuarios.Remove(u);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locacao.Model;

namespace Locacao.Controller
{
    public class UsuarioController
    {
        //  public List<Usuario> usuarios;
        LocacaoContext db = new LocacaoContext();
        public UsuarioController()
        {
  
        }
        public List<Usuario> GetUsuarios()
        {
            return db.usuarios.Where(x => x.Ativo).ToList();
        }
        public void AdicionaUsuario(Usuario u)
        {
           
            u.Id = LocacaoContext.indiceUsuarios;
            db.usuarios.Add(u);
            LocacaoContext.indiceUsuarios++;
        }
        public void RemoveUsuario(Usuario u)
        {
           db.usuarios.Remove(u);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary.Model;
namespace EntityLibrary.Control
{
    public class PessoaController
    {
        EntityContextDB Context = new EntityContextDB();

        public IQueryable<Pessoa> GetPessoas()
        {
            return Context.Lista_Pessoas;
        }
        /// <summary>
        /// Adiciona uma pessoa no banco
        /// </summary>
        /// <param name="p"> Instancia de Pessoa </param>
        public void AddPessoa(Pessoa p)
        {
            Context.Lista_Pessoas.Add(p);
            Context.SaveChanges();
        }
    }


}

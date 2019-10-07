using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolBackEnd.Model;
namespace SchoolBackEnd.Controller
{
   public  class AlunoController
    {
        Context Context = new Context();

        public IQueryable<Aluno> GetAlunos()
        {
            return Context.Lista_Alunos;
        }
        /// <summary>
        /// Adiciona uma pessoa no banco
        /// </summary>
        /// <param name="p"> Instancia de Pessoa </param>
        public void AddAluno(Aluno a)
        {
            Context.Lista_Alunos.Add(a);


        }
        public void SaveChanges() {
            Context.SaveChanges();
        }
    }
}

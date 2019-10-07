using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolBackEnd.Model;
namespace SchoolBackEnd.Model
{
    public class Context : DbContext
    {
        public DbSet<Aluno> Lista_Alunos { get; set; }
    }
}

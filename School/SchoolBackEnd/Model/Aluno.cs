using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBackEnd.Model
{
   public class Aluno
    {
        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public Aluno() {
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        public int Idade { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}\nIdade: {Idade}";
        }
    }
}

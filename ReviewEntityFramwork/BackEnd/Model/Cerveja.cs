using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Model
{
    public class Cerveja
    {
        public Cerveja(string nome, string tipo) {
            Nome = nome;
            Tipo = tipo;
        }
        public Cerveja() { }

        [Key]
        public int Id { get; set; }
      
        [StringLength(50)]
        public string Nome { get; set; }
        [StringLength(30)]
        public string Tipo { get; set; }
        public double TeorAlcool { get; set; }
        public override string ToString()
        {
            return $"{Nome}       {Tipo}      {TeorAlcool}";
        }
    }
}

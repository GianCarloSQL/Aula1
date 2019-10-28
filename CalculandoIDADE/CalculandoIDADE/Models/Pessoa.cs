using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CalculandoIDADE.Models
{
    public class Pessoa
    {
        [Key]
        public int ID { get; set; }
        public int Idade { get; set; }
        public string Nome { get; set; }
    }
}
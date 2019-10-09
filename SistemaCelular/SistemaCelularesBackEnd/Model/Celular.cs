using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularLibrary.Model
{
    public class Celular : AbstractControl
    {
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public double Preco { get; set; }

        public override void Update()
        {
            DataAlteracao = DateTime.Now;
        }
        public override string ToString()
        {
            return $"ID: {Id}   Marca: {Marca}";
        }
    }
}

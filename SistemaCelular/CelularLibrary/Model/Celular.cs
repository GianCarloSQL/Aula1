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
        [MaxLength(30)]
        public string Marca { get; set; }
        [Required]
        [MaxLength(30)]
        public string Modelo { get; set; }
        [Required]
        public double Preco { get; set; }

        public override void Update()
        {
            DataAlteracao = DateTime.Now;
        }
    }
}

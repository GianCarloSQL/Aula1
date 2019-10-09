using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularLibrary.Model
{
    public class Usuario : AbstractControl
    {
        public string Nome { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public int Senha { get; set; }

        public override void Update()
        {
            DataAlteracao = DateTime.Now;
        }
    }
}

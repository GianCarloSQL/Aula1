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
        [MaxLength(50)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(50)]
        public string Login { get; set; }
        [Required]
        [MaxLength(50)]
        public int Senha { get; set; }

        public override void Update()
        {
            DataAlteracao = DateTime.Now;
        }
    }
}

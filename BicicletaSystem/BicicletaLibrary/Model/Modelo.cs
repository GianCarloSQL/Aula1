using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locacao.Model;
namespace BicicletaLibrary.Model
{
    public class Modelo : AbstractModel
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public Marca marca { get; set; }

        public override void Update()
        {
            DataAlteracao = DateTime.Now;
        }
    }
}

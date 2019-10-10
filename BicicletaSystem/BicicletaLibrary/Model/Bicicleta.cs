using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locacao.Model;
namespace BicicletaLibrary.Model
{
    
    public class Bicicleta : AbstractModel
    {
        public Bicicleta() { }

        public Bicicleta(string model) {
            this.Modelo = model;
        }

        [Required]
        public string Modelo { get; set; }
        public override void Update()
        {
            DataAlteracao = DateTime.Now;
        }
    }
}

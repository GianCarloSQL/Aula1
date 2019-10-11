using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseToEntity.Model
{
    public class ControleUsuario
    {
        public bool? Ativo { get; set; }

        public int? UsuarioCriacao { get; set; }

        public int? UsuarioAlteracao { get; set; }

        public DateTime? DataCriacao { get; set; } = DateTime.Now;

        [Column(TypeName = "date")]
        public DateTime? DataAlteracao { get; set; } = DateTime.Now;
    }
}

namespace DatabaseToEntity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pedido")]
    public partial class Pedido : ControleUsuario
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Numero { get; set; }

        public int ClienteId { get; set; }

        [Column(TypeName = "money")]
        public decimal Valor { get; set; }


        public virtual Cliente Cliente { get; set; }
    }
}

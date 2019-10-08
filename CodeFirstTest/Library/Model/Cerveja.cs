namespace Library.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cerveja
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(30)]
        public string Tipo { get; set; }

        public double TeorAlcool { get; set; }
    }
}

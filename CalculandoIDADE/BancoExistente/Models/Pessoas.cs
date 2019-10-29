namespace BancoExistente.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pessoas
    {
        public int ID { get; set; }

        public int Idade { get; set; }

        public string Nome { get; set; }
    }
}

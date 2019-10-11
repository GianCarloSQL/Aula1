namespace DatabaseToEntity.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Pedido> Pedidoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nome)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Pedidoes)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pedido>()
                .Property(e => e.Numero)
                .IsFixedLength();

            modelBuilder.Entity<Pedido>()
                .Property(e => e.Valor)
                .HasPrecision(19, 4);
        }
    }
}

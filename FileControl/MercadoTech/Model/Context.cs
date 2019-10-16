namespace MercadoTech.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
        private static Context Singleton = new Context();
        public static Context GetInstance()
        {
            return Singleton;
        }

        public DbSet<Colaborador> Colaborador { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }
        public DbSet<Locacao> Locacao { get; set; }
        public DbSet<Cor> Cor { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<TipoVeiculo> Tipo_Veiculo { get; set; }
        public DbSet<Modelo> Modelo { get; set; }

        // Your context has been configured to use a 'Context' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MercadoTech.Model.Context' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Context' 
        // connection string in the application configuration file.
        private Context()
            : base("name=Context")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
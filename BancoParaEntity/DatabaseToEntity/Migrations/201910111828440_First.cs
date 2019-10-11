namespace DatabaseToEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, fixedLength: true),
                        Genero = c.Int(),
                        Idade = c.Int(),
                        Ativo = c.Boolean(),
                        UsuarioCriacao = c.Int(),
                        UsuarioAlteracao = c.Int(),
                        DataCriacao = c.DateTime(),
                        DataAlteracao = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        ClienteId = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, storeType: "money"),
                        Ativo = c.Boolean(),
                        UsuarioCriacao = c.Int(),
                        UsuarioAlteracao = c.Int(),
                        DataCriacao = c.DateTime(),
                        DataAlteracao = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedido", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Pedido", new[] { "ClienteId" });
            DropTable("dbo.Pedido");
            DropTable("dbo.Cliente");
        }
    }
}

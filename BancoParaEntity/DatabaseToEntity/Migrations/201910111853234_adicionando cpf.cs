namespace DatabaseToEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionandocpf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "CPF", c => c.String(maxLength: 11));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cliente", "CPF");
        }
    }
}

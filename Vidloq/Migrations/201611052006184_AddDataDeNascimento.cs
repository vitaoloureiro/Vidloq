namespace Vidloq.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataDeNascimento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "DataNascimento", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Planos", "Titulo", c => c.String(nullable: false, maxLength: 150, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Planos", "Titulo", c => c.String(maxLength: 100, unicode: false));
            DropColumn("dbo.Clientes", "DataNascimento");
        }
    }
}

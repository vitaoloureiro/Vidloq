namespace Vidloq.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTituloAPlanos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Planos", "Titulo", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Planos", "Titulo");
        }
    }
}

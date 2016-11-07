namespace Vidloq.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClienteValidacao : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "DataNascimento", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "DataNascimento", c => c.DateTime());
        }
    }
}

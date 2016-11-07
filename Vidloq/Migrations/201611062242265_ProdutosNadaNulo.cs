namespace Vidloq.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProdutosNadaNulo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produtos", "DataLancamento", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtos", "DataLancamento", c => c.DateTime());
        }
    }
}

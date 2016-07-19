namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CatalogId = c.Int(nullable: false),
                        base1 = c.String(),
                        base2 = c.String(),
                        Prod1_p1a = c.String(),
                        Prod1_p1b = c.String(),
                        Prod2_p2a = c.String(),
                        Prod2_p2b = c.String(),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}

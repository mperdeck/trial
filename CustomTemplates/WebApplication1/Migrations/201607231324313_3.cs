namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Children", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.Children", new[] { "Product_ProductId" });
            RenameColumn(table: "dbo.Children", name: "Product_ProductId", newName: "ProductId");
            AlterColumn("dbo.Children", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.Children", "ProductId");
            AddForeignKey("dbo.Children", "ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Children", "ProductId", "dbo.Products");
            DropIndex("dbo.Children", new[] { "ProductId" });
            AlterColumn("dbo.Children", "ProductId", c => c.Int());
            RenameColumn(table: "dbo.Children", name: "ProductId", newName: "Product_ProductId");
            CreateIndex("dbo.Children", "Product_ProductId");
            AddForeignKey("dbo.Children", "Product_ProductId", "dbo.Products", "ProductId");
        }
    }
}

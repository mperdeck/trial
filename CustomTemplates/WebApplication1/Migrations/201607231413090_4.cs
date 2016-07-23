namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Prod1_p1a");
            DropColumn("dbo.Products", "Prod1_p1b");
            DropColumn("dbo.Products", "Prod2_p2a");
            DropColumn("dbo.Products", "Prod2_p2b");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Prod2_p2b", c => c.String());
            AddColumn("dbo.Products", "Prod2_p2a", c => c.String());
            AddColumn("dbo.Products", "Prod1_p1b", c => c.String());
            AddColumn("dbo.Products", "Prod1_p1a", c => c.String());
        }
    }
}

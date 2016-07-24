namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Prod1_p1a", c => c.String());
            AddColumn("dbo.Products", "Prod1_p1b", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Prod1_p1b");
            DropColumn("dbo.Products", "Prod1_p1a");
        }
    }
}

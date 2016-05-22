namespace SimpleSiteWithDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renamefield : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Booklet3",
                c => new
                    {
                        Booklet3Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ISDNlet = c.String(),
                    })
                .PrimaryKey(t => t.Booklet3Id);
            
            AddColumn("dbo.Booklet2", "ISDNlet2", c => c.String());
            DropColumn("dbo.Booklet2", "ISDNlet");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Booklet2", "ISDNlet", c => c.String());
            DropColumn("dbo.Booklet2", "ISDNlet2");
            DropTable("dbo.Booklet3");
        }
    }
}

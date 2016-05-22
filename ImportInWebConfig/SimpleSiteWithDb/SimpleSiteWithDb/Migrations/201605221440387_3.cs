namespace SimpleSiteWithDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Booklet3");
        }
    }
}

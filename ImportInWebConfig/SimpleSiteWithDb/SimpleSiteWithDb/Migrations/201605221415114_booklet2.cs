namespace SimpleSiteWithDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class booklet2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Booklet2",
                c => new
                    {
                        Booklet2Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ISDNlet = c.String(),
                    })
                .PrimaryKey(t => t.Booklet2Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Booklet2");
        }
    }
}

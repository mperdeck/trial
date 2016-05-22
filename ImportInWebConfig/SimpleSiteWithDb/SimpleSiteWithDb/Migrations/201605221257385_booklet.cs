namespace SimpleSiteWithDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class booklet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Booklets",
                c => new
                    {
                        BookletId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ISDNlet = c.String(),
                    })
                .PrimaryKey(t => t.BookletId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Booklets");
        }
    }
}

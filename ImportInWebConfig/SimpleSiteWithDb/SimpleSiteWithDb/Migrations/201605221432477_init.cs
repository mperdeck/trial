namespace SimpleSiteWithDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
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
            
            CreateTable(
                "dbo.Booklets",
                c => new
                    {
                        BookletId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ISDNlet = c.String(),
                    })
                .PrimaryKey(t => t.BookletId);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ISDN = c.String(),
                    })
                .PrimaryKey(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
            DropTable("dbo.Booklets");
            DropTable("dbo.Booklet2");
        }
    }
}

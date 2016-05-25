namespace SimpleSiteWithDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE [dbo].[Books] SET [ISDN] = 'xxxx';");



        }

        public override void Down()
        {
        }
    }
}

namespace timeManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OwnerIdIntToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Companies", "OwnerId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Companies", "OwnerId", c => c.Int());
        }
    }
}

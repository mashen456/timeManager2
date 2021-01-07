namespace timeManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedOwnerIdToCompany : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "OwnerId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "OwnerId");
        }
    }
}

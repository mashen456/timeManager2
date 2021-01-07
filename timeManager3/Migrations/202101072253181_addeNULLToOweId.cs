namespace timeManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeNULLToOweId : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Companies", "OwnerId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Companies", "OwnerId", c => c.Int(nullable: false));
        }
    }
}

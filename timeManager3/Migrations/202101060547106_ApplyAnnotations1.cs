namespace timeManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotations1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerTypes", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerTypes", "Name", c => c.String());
        }
    }
}

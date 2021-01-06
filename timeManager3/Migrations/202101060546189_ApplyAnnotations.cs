namespace timeManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Companies", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Companies", "Address", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Companies", "Zip", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Companies", "Country", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Companies", "Country", c => c.String());
            AlterColumn("dbo.Companies", "Zip", c => c.String());
            AlterColumn("dbo.Companies", "Address", c => c.String());
            AlterColumn("dbo.Companies", "Name", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}

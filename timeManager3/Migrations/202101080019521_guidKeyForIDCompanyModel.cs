namespace timeManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class guidKeyForIDCompanyModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "CompanyId", "dbo.Companies");
            DropPrimaryKey("dbo.Companies");
            AddColumn("dbo.Companies", "InvKey", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.Companies", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Companies", "Id");
            AddForeignKey("dbo.Customers", "CompanyId", "dbo.Companies", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "CompanyId", "dbo.Companies");
            DropPrimaryKey("dbo.Companies");
            AlterColumn("dbo.Companies", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Companies", "InvKey");
            AddPrimaryKey("dbo.Companies", "Id");
            AddForeignKey("dbo.Customers", "CompanyId", "dbo.Companies", "Id", cascadeDelete: true);
        }
    }
}

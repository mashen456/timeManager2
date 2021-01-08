namespace timeManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employetest3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.employes", "CompanyId", c => c.Int(nullable: false));
            CreateIndex("dbo.employes", "CompanyId");
            AddForeignKey("dbo.employes", "CompanyId", "dbo.Companies", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.employes", "CompanyId", "dbo.Companies");
            DropIndex("dbo.employes", new[] { "CompanyId" });
            DropColumn("dbo.employes", "CompanyId");
        }
    }
}

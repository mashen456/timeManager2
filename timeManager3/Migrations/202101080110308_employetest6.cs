namespace timeManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employetest6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.employes", "ClientId", "dbo.AspNetUsers");
            DropForeignKey("dbo.employes", "CompanyId", "dbo.Companies");
            DropIndex("dbo.employes", new[] { "CompanyId" });
            DropIndex("dbo.employes", new[] { "ClientId" });
            DropTable("dbo.employes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.employes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(nullable: false),
                        ClientId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.employes", "ClientId");
            CreateIndex("dbo.employes", "CompanyId");
            AddForeignKey("dbo.employes", "CompanyId", "dbo.Companies", "Id", cascadeDelete: true);
            AddForeignKey("dbo.employes", "ClientId", "dbo.AspNetUsers", "Id");
        }
    }
}

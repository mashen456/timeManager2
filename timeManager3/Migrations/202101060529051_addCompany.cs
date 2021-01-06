namespace timeManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCompany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Zip = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "CompanyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "CompanyId");
            AddForeignKey("dbo.Customers", "CompanyId", "dbo.Companies", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "CompanyId", "dbo.Companies");
            DropIndex("dbo.Customers", new[] { "CompanyId" });
            DropColumn("dbo.Customers", "CompanyId");
            DropTable("dbo.Companies");
        }
    }
}

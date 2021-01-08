namespace timeManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedSomeTypes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Customers", "CustomerTypeId", "dbo.CustomerTypes");
            DropIndex("dbo.Customers", new[] { "CompanyId" });
            DropIndex("dbo.Customers", new[] { "CustomerTypeId" });
            DropTable("dbo.Customers");
            DropTable("dbo.CustomerTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CustomerTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                        Type = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(nullable: false),
                        CustomerTypeId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Customers", "CustomerTypeId");
            CreateIndex("dbo.Customers", "CompanyId");
            AddForeignKey("dbo.Customers", "CustomerTypeId", "dbo.CustomerTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Customers", "CompanyId", "dbo.Companies", "Id", cascadeDelete: true);
        }
    }
}

namespace timeManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCustomerType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                        Type = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "CustomerTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "CustomerTypeId");
            AddForeignKey("dbo.Customers", "CustomerTypeId", "dbo.CustomerTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "CustomerTypeId", "dbo.CustomerTypes");
            DropIndex("dbo.Customers", new[] { "CustomerTypeId" });
            DropColumn("dbo.Customers", "CustomerTypeId");
            DropTable("dbo.CustomerTypes");
        }
    }
}

namespace timeManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employetest21 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.employes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.employes", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.employes", new[] { "ApplicationUser_Id" });
            DropTable("dbo.employes");
        }
    }
}
